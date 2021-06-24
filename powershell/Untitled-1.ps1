$list=@()
for ($i = 0; $i -le 100; $i++) {
    $randomnum=Get-Random -Maximum 100 -Minimum 50
    $list +=$randomnum

}
$list |Group-Object |sort -Property count

