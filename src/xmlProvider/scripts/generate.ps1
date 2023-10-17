function GenerateFiles($path, $namespace, $importFiles) 
{
    $file = Get-Item -Path $path
    $ddd = "xmlProvider.Objects" + $file.Name
    echo $ddd
    xsd /c /n:$ddd /o:Objects /nologo $file.FullName 
}

#GenerateFiles("xsd/ZUSE.xsd")
#GenerateFiles("xsd/ZUSEB.xsd")
#GenerateFiles("xsd/ZOPMB.xsd")
#GenerateFiles("xsd/ZPP.xsd")
#GenerateFiles("xsd/ZOT.xsd")
#GenerateFiles("xsd/ZOMB.xsd")
GenerateFiles("xsd/ZGWM.xsd")