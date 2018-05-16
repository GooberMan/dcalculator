@echo off
set "DMDPath=C:\Program Files (x86)\dlang\dmd.2.078.0.windows\dmd2\windows\bin"
set "BinderooPath=..\binderoo"
if [%1] == [] (
	set "Config=release"
) else (
	set "Config=%1"
)
if %Config% == "debug" (
	set "Flags=-debug"
) else (
	set "Flags="
)
"%DMDPath%\dmd" -m64 -shared %Flags% -g -ofbin\Windows_NT\x64\%Config%\dcalculatornative.dll -I%BinderooPath%/binderoo_client/d/src dcalculator.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/attributes.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/binding.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/boundenum.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/boundfunction.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/boundmodule.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/boundobject.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/cheaderobjects.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/cheaderparsing.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/cppfunctiongenerator.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/functionstub.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/inheritance.d %BinderooPath%/binderoo_client/d/src/binderoo/binding/serialise.d %BinderooPath%/binderoo_client/d/src/binderoo/descriptorsearch.d %BinderooPath%/binderoo_client/d/src/binderoo/functiondescriptor.d %BinderooPath%/binderoo_client/d/src/binderoo/hash.d %BinderooPath%/binderoo_client/d/src/binderoo/math/angle.d %BinderooPath%/binderoo_client/d/src/binderoo/math/constants.d %BinderooPath%/binderoo_client/d/src/binderoo/math/quaternion.d %BinderooPath%/binderoo_client/d/src/binderoo/math/transform.d %BinderooPath%/binderoo_client/d/src/binderoo/math/vector.d %BinderooPath%/binderoo_client/d/src/binderoo/objectprivacy.d %BinderooPath%/binderoo_client/d/src/binderoo/scripting/attributes.d %BinderooPath%/binderoo_client/d/src/binderoo/scripting/scripting.d %BinderooPath%/binderoo_client/d/src/binderoo/slice.d %BinderooPath%/binderoo_client/d/src/binderoo/traits.d %BinderooPath%/binderoo_client/d/src/binderoo/typedescriptor.d %BinderooPath%/binderoo_client/d/src/binderoo/util/atomic.d %BinderooPath%/binderoo_client/d/src/binderoo/util/bitpacking.d %BinderooPath%/binderoo_client/d/src/binderoo/util/builtin.d %BinderooPath%/binderoo_client/d/src/binderoo/util/structofarrays.d %BinderooPath%/binderoo_client/d/src/binderoo/variabledescriptor.d %BinderooPath%/binderoo_client/d/src/binderoo_client.d
if %ERRORLEVEL% neq 0 goto error
"%BinderooPath%\bin\vs2015\binderoo_host\x64\Debug\binderoo_util" -f bin\Windows_NT\x64\%Config% -ic#A >DCalculatorGenerated.cs
goto finish

:error
echo IT BROKE!
exit /B %ERRORLEVEL%

:finish
