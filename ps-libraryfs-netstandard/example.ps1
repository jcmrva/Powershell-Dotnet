
$root = (Get-Item -Path ".\").FullName

Set-Location .\lib\Example

dotnet publish --output (Join-Path $root -ChildPath "publish")

Set-Location ..\..

Add-Type -Path ".\publish\Example.dll"

[Example.ClassName]::FsHello

$instance = [Example.ClassName]::new("PS")
$instance.Greeting()

[Example.Math]::cube(2)

$r = [Example.FsTypes]::r
$r
$r.gettype()
if ($r.Union.IsC) {
    $r.Union.Item1
}

$r3 = [Example.FsTypes]::CreateMyRec("test", "String")
$r3

$rl = New-Object System.Collections.ArrayList
$rl.AddRange( ("Make","me","a","list") )
[Example.FsTypes]::createMyRecList($rl)
