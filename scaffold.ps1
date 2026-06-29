Import-Module powershell-yaml

$yaml = Get-Content "./appsettings.yaml" -Raw | ConvertFrom-Yaml

$connection = $yaml.ConnectionStrings.CCOS

dotnet ef dbcontext scaffold `
$connection `
Oracle.EntityFrameworkCore `
--schema RCTCCOS `
--output-dir Data/Models `
--context-dir Data/ `
--context DBContext `
--context-namespace Worker_Report.Data `
--namespace Worker_Report.Data.Models `
--use-database-names `
--data-annotations `
--no-pluralize `
--no-onconfiguring `
--force