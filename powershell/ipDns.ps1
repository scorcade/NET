$wmi = Get-WmiObject win32_networkadapterconfiguration -filter "ipenabled = 'true'"
$wmi.EnableStatic("192.168.1.209", "255.255.255.0")
$wmi.SetGateways("192.168.1.1", 1)
$wmi.SetDNSServerSearchOrder("4.2.2.1")