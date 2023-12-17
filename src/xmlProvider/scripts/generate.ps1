function GenerateObject($objName, [string[]]$importFiles) 
{
    $file = "xsd/$objName.xsd"
    $namespace = "xmlObjectProvider.Objects.generated.$objName"
    $xsdCommand = "xsd $importFiles $file /c /n:$namespace /o:Objects/generated /nologo"
    Invoke-Expression $xsdCommand
}


GenerateObject "OGWM" "xsd/DEF_GWM/GWM-schedule-xml.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-etso-code-lists.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-anomaly-xml.xsd xsd/DEF_GWM/GWM-confirmation-xml.xsd xsd/DEF_GWM/GWM-acknowledgement-xml.xsd"
GenerateObject "IGWM" "xsd/DEF_GWM/GWM-schedule-xml.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-etso-code-lists.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-anomaly-xml.xsd xsd/DEF_GWM/GWM-confirmation-xml.xsd xsd/DEF_GWM/GWM-acknowledgement-xml.xsd"
GenerateObject "UGWM" "xsd/DEF_GWM/GWM-schedule-xml.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-etso-code-lists.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-anomaly-xml.xsd xsd/DEF_GWM/GWM-confirmation-xml.xsd xsd/DEF_GWM/GWM-acknowledgement-xml.xsd"
GenerateObject "PGWM" "xsd/DEF_GWM/GWM-schedule-xml.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-etso-code-lists.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-anomaly-xml.xsd xsd/DEF_GWM/GWM-confirmation-xml.xsd xsd/DEF_GWM/GWM-acknowledgement-xml.xsd"

#GWM-anomaly-xml.xsd
#GenerateObject "ZUSE"
#GenerateObject "ZUSEB"
#GenerateObject "ZOPMB"
#GenerateObject "ZOEB"
#GenerateObject "ZOMB"
#GenerateObject "ZPP"
#GenerateObject "ZOT"
# for xsd with referenced elements from different namespace reffered files must be provided to xsd
#GenerateObject "ZGWM" "xsd/DEF_GWM/GWM-schedule-xml.xsd xsd/DEF_GWM/GWM-etso-core-cmpts.xsd xsd/DEF_GWM/GWM-etso-code-lists.xsd"