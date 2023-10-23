function GenerateObject($objName, [string[]]$importFiles) 
{
    $file = "xsd/$objName.xsd"
    $namespace = "xmlObjectProvider.Objects.generated.$objName"
    $xsdCommand = "xsd $importFiles $file /c /n:$namespace /o:Objects/generated /nologo"
    Invoke-Expression $xsdCommand
}

GenerateObject "ZUSE"
GenerateObject "ZUSEB"
GenerateObject "ZOPMB"
GenerateObject "ZOEB"
GenerateObject "ZOMB"
GenerateObject "ZPP"
GenerateObject "ZOT"
# for xsd with referenced elements from different namespace reffered files must be provided to xsd
GenerateObject "ZGWM" "xsd/DEF_GWM/GWM-schedule-xml.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-etso-code-lists.xsd"