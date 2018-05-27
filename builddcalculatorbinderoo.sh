BinderooPath="../binderoo"

if [ "$2" != "monodevelop" ]; then
	if [ "$1" == "" ] || [ "${1,,}" == "release" ]; then
		Build="Release"
	elif [ "${1,,}" == "debug" ]; then
		Build="Debug"
	else
		echo "Invalid option \"$1\", must be either \"debug\" or \"release\"."
		exit 1
	fi

	if [ "$Build" == "Debug" ]; then
		Flags="-d-debug -link-debuglib"
	else
		Flags=""
	fi

	/usr/bin/ldc2 -m64 -shared $Flags -g -ofbin/Unix/x64/$Build/dcalculatornative.so -I$BinderooPath/binderoo_client/d/src dcalculator.d $BinderooPath/binderoo_client/d/src/binderoo/binding/attributes.d $BinderooPath/binderoo_client/d/src/binderoo/binding/boundenum.d $BinderooPath/binderoo_client/d/src/binderoo/binding/boundfunction.d $BinderooPath/binderoo_client/d/src/binderoo/binding/boundmodule.d $BinderooPath/binderoo_client/d/src/binderoo/binding/boundobject.d $BinderooPath/binderoo_client/d/src/binderoo/binding/cheaderobjects.d $BinderooPath/binderoo_client/d/src/binderoo/binding/cheaderparsing.d $BinderooPath/binderoo_client/d/src/binderoo/binding/cppfunctiongenerator.d $BinderooPath/binderoo_client/d/src/binderoo/binding/functionstub.d $BinderooPath/binderoo_client/d/src/binderoo/binding/inheritance.d $BinderooPath/binderoo_client/d/src/binderoo/binding/mangler.d $BinderooPath/binderoo_client/d/src/binderoo/binding/package.d $BinderooPath/binderoo_client/d/src/binderoo/binding/serialise.d $BinderooPath/binderoo_client/d/src/binderoo/descriptorsearch.d $BinderooPath/binderoo_client/d/src/binderoo/functiondescriptor.d $BinderooPath/binderoo_client/d/src/binderoo/hash.d $BinderooPath/binderoo_client/d/src/binderoo/math/angle.d $BinderooPath/binderoo_client/d/src/binderoo/math/constants.d $BinderooPath/binderoo_client/d/src/binderoo/math/quaternion.d $BinderooPath/binderoo_client/d/src/binderoo/math/transform.d $BinderooPath/binderoo_client/d/src/binderoo/math/vector.d $BinderooPath/binderoo_client/d/src/binderoo/objectprivacy.d $BinderooPath/binderoo_client/d/src/binderoo/scripting/attributes.d $BinderooPath/binderoo_client/d/src/binderoo/scripting/scripting.d $BinderooPath/binderoo_client/d/src/binderoo/slice.d $BinderooPath/binderoo_client/d/src/binderoo/traits.d $BinderooPath/binderoo_client/d/src/binderoo/typedescriptor.d $BinderooPath/binderoo_client/d/src/binderoo/util/atomic.d $BinderooPath/binderoo_client/d/src/binderoo/util/bitpacking.d $BinderooPath/binderoo_client/d/src/binderoo/util/builtin.d $BinderooPath/binderoo_client/d/src/binderoo/util/structofarrays.d $BinderooPath/binderoo_client/d/src/binderoo/variabledescriptor.d $BinderooPath/binderoo_client/d/src/binderoo_client.d
	if [ $? != 0 ]; then
		echo "IT BROKE!"
		exit $rc
	fi

	"./$BinderooPath/bin/Linux/binderoo_host/x86_64/$Build/binderoo_util" -f bin/Unix/x64/$Build -ic#A >DCalculatorGenerated.cs

fi