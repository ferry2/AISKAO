Foreach ($file in Get-ChildItem)
{
	if($file -like "R-3*.xsd") {C:\Progra~2\xsd2code\xsd2code.exe $file}
}
