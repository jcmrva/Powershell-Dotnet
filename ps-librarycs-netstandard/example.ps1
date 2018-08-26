
$root = (Get-Item -Path ".\").FullName

Set-Location .\lib\Example

dotnet publish --output (Join-Path $root -ChildPath "publish")

Set-Location ..\..

Add-Type -Path ".\publish\Example.dll"

[Example.Library]::RandomInt()

$instance = [Example.Library]::new()
$instance.WriteTuple()
