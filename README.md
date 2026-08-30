# Veri Aktarımı Uygulaması (Data Transfer Application)

A Windows Forms application built during a software engineering internship at the **T.C. İçişleri Bakanlığı (Turkish Ministry of Interior), General Directorate of Information Technologies**. It recreates a real internal tool used by the Ministry to migrate rows from an MSSQL database into S3-compatible object storage, using a locally-hosted stand-in database and MinIO in place of the Ministry's actual production systems (interns don't have access to real Ministry data).

## What it does

- Connects to an MSSQL Server instance and lets the user pick a source table through a chain of dependent dropdowns (Server → Catalog → Schema → Table → primary/content key columns).
- For each row in the selected table, reads a corresponding local file named `{ContentId}_{ContentRevId}.txt` and uploads it to a MinIO bucket via the AWS S3 SDK, then deletes the local file once the upload succeeds.
- Includes a secondary "Log Table" tool that generates a `CREATE TABLE` script for an audit/log table, validating that an existing table's schema matches an expected set of columns before letting the transfer run.
- Reports progress and errors live in a log panel (Serilog piped into a `RichTextBox`), with a progress bar and a choice between "stop on error" and "continue on error" for the batch job.

## Why it's built this way

This app is a from-scratch reimplementation of a real tool used in the Ministry's Altyapı Geliştirme ve Ar-Ge (Infrastructure Development & R&D) unit, built to learn how their production data-migration pipeline works without touching real citizen data. MinIO stands in for the Ministry's actual object storage target, and the sample MSSQL table (`TestIcerik`) stands in for their real content table, seeded with dummy rows for testing.

## Tech stack

| Layer | Tool |
|---|---|
| UI | Windows Forms, .NET 8.0 |
| Database | Microsoft SQL Server 2022 (via Docker) |
| Object storage | MinIO (S3-compatible, via Docker), accessed with `AWSSDK.S3` |
| Data access | [Dapper](https://github.com/DapperLib/Dapper) |
| Logging | Serilog + `Serilog.Sinks.RichTextBox.WinForms.Colored` |

## Architecture

- `Form1` — main screen: database/table selection, MinIO connection fields, and the start/stop transfer controls. Runs the transfer on a `BackgroundWorker` so the UI stays responsive and the job can be cancelled mid-run.
- `Form2` — the "Create Script" tool: generates a `CREATE TABLE` statement for a new log table from a hardcoded column spec (`LogTableColumnsAsColumn`).
- `Column.cs` — a small DTO (`COLUMN_NAME`, `IS_NULLABLE`, `DATA_TYPE`, `CHARACTER_MAXIMUM_LENGTH`) used to compare a target table's actual schema against the expected one via `INFORMATION_SCHEMA.COLUMNS` queries.

## Running it locally

You'll need Docker, .NET 8.0, and Visual Studio (or the `dotnet` CLI).

1. Start an MSSQL container:
docker run -e "MSSQL_SA_PASSWORD=<your-password>" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
2. Start a MinIO container:
docker run -p 9000:9000 -p 9001:9001 -e "MINIO_ROOT_USER=<user>" -e "MINIO_ROOT_PASSWORD=<password>" minio/minio server /data --console-address ":9001"
3. Create a test database/table and a MinIO bucket, then update the connection details in the app's UI at runtime (source, catalog, MinIO access key/secret/service URL, bucket name).
4. Build and run `veri_transferi.sln`.

## Known limitations

- The MSSQL connection string is hardcoded in `Form1.cs` for local development convenience; it should move to configuration (`appsettings.json` or environment variables) before this pattern is reused anywhere beyond a demo.
- Built to mirror an internal tool's exact screen layout and flow rather than to be a general-purpose migration utility, so some field names (`WccIcerikId`, `WccIcerikRevId`) reflect the Ministry's original naming and won't mean much outside that context.

## Context

Built in the first two weeks of a four-week internship (August–September 2024) at T.C. İçişleri Bakanlığı. The remaining two weeks were spent on a companion personal-website project (ASP.NET Core MVC + MySQL), it can be found here: https://github.com/chibielif/mywebsite.
