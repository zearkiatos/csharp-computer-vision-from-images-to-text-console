param(
    [Parameter(Position = 0)]
    [string]$Command = "help"
)

$project = Join-Path $PSScriptRoot "ComputerVisionFromImagesToTextConsole.csproj"

switch ($Command.ToLowerInvariant()) {
    "run" {
        & dotnet run --project $project
        exit $LASTEXITCODE
    }
    "build" {
        & dotnet build $project
        exit $LASTEXITCODE
    }
    { $_ -in "help", "-h", "--help" } {
        Write-Output "Uso: .\run.ps1 [comando]"
        Write-Output ""
        Write-Output "Comandos:"
        Write-Output "  run    Ejecuta la aplicación"
        Write-Output "  build  Compila la aplicación"
        Write-Output "  help   Muestra esta ayuda"
        exit 0
    }
    default {
        Write-Error "Comando desconocido: $Command. Usa '.\run.ps1 help' para ver los comandos."
        exit 1
    }
}