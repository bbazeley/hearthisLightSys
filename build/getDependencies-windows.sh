#!/bin/bash
# server=build.palaso.org
# project=HearThis
# build=
# root_dir=..
# Auto-generated by https://github.com/chrisvire/BuildUpdate.
# Do not edit this file by hand!

cd "$(dirname "$0")"

# *** Functions ***
force=0
clean=0

while getopts fc opt; do
case $opt in
f) force=1 ;;
c) clean=1 ;;
esac
done

shift $((OPTIND - 1))

copy_auto() {
if [ "$clean" == "1" ]
then
echo cleaning $2
rm -f ""$2""
else
where_curl=$(type -P curl)
where_wget=$(type -P wget)
if [ "$where_curl" != "" ]
then
copy_curl $1 $2
elif [ "$where_wget" != "" ]
then
copy_wget $1 $2
else
echo "Missing curl or wget"
exit 1
fi
fi
}

copy_curl() {
echo "curl: $2 <= $1"
if [ -e "$2" ] && [ "$force" != "1" ]
then
curl -# -L -z $2 -o $2 $1
else
curl -# -L -o $2 $1
fi
}

copy_wget() {
echo "wget: $2 <= $1"
f=$(basename $2)
d=$(dirname $2)
cd $d
wget -q -L -N $1
cd -
}


# *** Results ***
# build: HearThis-Win-Dev-Continuous (bt89)
# project: HearThis
# URL: http://build.palaso.org/viewType.html?buildTypeId=bt89
# VCS: https://bitbucket.org/sillsdev/hearthis [default]
# dependencies:
# [0] build: palaso-win32-master Continuous (bt223)
#     project: libpalaso
#     URL: http://build.palaso.org/viewType.html?buildTypeId=bt223
#     clean: false
#     revision: latest.lastSuccessful
#     paths: {"Palaso.dll"=>"lib/dotnet", "Palaso.pdb"=>"lib/dotnet"}
#     VCS: https://github.com/sillsdev/libpalaso.git [master]
# [1] build: palaso-win32-SILWritingSystems Continuous (bt440)
#     project: libpalaso
#     URL: http://build.palaso.org/viewType.html?buildTypeId=bt440
#     clean: false
#     revision: latest.lastSuccessful
#     paths: {"Palaso.BuildTasks.dll"=>"build/", "icu.net.dll"=>"lib/dotnet", "icudt54.dll"=>"lib/dotnet", "icuin54.dll"=>"lib/dotnet", "icuuc54.dll"=>"lib/dotnet", "Ionic.Zip.dll"=>"lib/dotnet", "L10NSharp.dll"=>"lib/dotnet", "L10NSharp.pdb"=>"lib/dotnet", "SIL.Core.dll"=>"lib/dotnet", "SIL.Core.pdb"=>"lib/dotnet", "Palaso.Media.dll"=>"lib/dotnet", "Palaso.Media.pdb"=>"lib/dotnet", "SIL.Windows.Forms.dll"=>"lib/dotnet", "SIL.Windows.Forms.pdb"=>"lib/dotnet"}
#     VCS: https://github.com/sillsdev/libpalaso.git [SILWritingSystems]

# make sure output directories exist
mkdir -p ../build/
mkdir -p ../lib/dotnet

# download artifact dependencies
copy_auto http://build.palaso.org/guestAuth/repository/download/bt223/latest.lastSuccessful/Palaso.dll ../lib/dotnet/Palaso.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt223/latest.lastSuccessful/Palaso.pdb ../lib/dotnet/Palaso.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/Palaso.BuildTasks.dll ../build/Palaso.BuildTasks.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/icu.net.dll ../lib/dotnet/icu.net.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/icudt54.dll ../lib/dotnet/icudt54.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/icuin54.dll ../lib/dotnet/icuin54.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/icuuc54.dll ../lib/dotnet/icuuc54.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/Ionic.Zip.dll ../lib/dotnet/Ionic.Zip.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/L10NSharp.dll ../lib/dotnet/L10NSharp.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/L10NSharp.pdb ../lib/dotnet/L10NSharp.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/SIL.Core.dll ../lib/dotnet/SIL.Core.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/SIL.Core.pdb ../lib/dotnet/SIL.Core.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/Palaso.Media.dll ../lib/dotnet/Palaso.Media.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/Palaso.Media.pdb ../lib/dotnet/Palaso.Media.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/SIL.Windows.Forms.dll ../lib/dotnet/SIL.Windows.Forms.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt440/latest.lastSuccessful/SIL.Windows.Forms.pdb ../lib/dotnet/SIL.Windows.Forms.pdb
# End of script
