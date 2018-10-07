param([string]$MyParam = 'default', [switch]$Test)

write-host "Message from .NET: $MyParam"

if ($Test) {
    write-host "Test switch provided."
}

$PSVersionTable