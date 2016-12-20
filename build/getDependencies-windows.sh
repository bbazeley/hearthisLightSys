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
f1=$(basename $1)
f2=$(basename $2)
cd $(dirname $2)
wget -q -L -N $1
# wget has no true equivalent of curl's -o option.
# Different versions of wget handle (or not) % escaping differently.
# A URL query is the only reason why $f1 and $f2 should differ.
if [ "$f1" != "$f2" ]; then mv $f2\?* $f2; fi
cd -
}


# *** Results ***
# build: HearThis-Win-Dev-Continuous-PT8 (HearThis_HearThisWinDevContinuousPt8)
# project: HearThis
# URL: http://build.palaso.org/viewType.html?buildTypeId=HearThis_HearThisWinDevContinuousPt8
# VCS: https://github.com/sillsdev/HearThis.git [SupportPT8]
# dependencies:
# [0] build: palaso-win32-master-nostrongname Continuous (bt436)
#     project: libpalaso
#     URL: http://build.palaso.org/viewType.html?buildTypeId=bt436
#     clean: false
#     revision: latest.lastSuccessful
#     paths: {"Palaso.BuildTasks.dll"=>"build/", "Ionic.Zip.dll"=>"lib/dotnet", "L10NSharp.dll"=>"lib/dotnet", "L10NSharp.pdb"=>"lib/dotnet", "SIL.Core.dll"=>"lib/dotnet", "SIL.Core.pdb"=>"lib/dotnet", "SIL.DblBundle.dll"=>"lib/dotnet", "SIL.DblBundle.pdb"=>"lib/dotnet", "SIL.Media.dll"=>"lib/dotnet", "SIL.Media.pdb"=>"lib/dotnet", "SIL.Scripture.dll"=>"lib/dotnet", "SIL.Scripture.pdb"=>"lib/dotnet", "SIL.Windows.Forms.dll"=>"lib/dotnet", "SIL.Windows.Forms.pdb"=>"lib/dotnet", "SIL.Windows.Forms.DblBundle.dll"=>"lib/dotnet", "SIL.Windows.Forms.DblBundle.pdb"=>"lib/dotnet", "SIL.WritingSystems.dll"=>"lib/dotnet", "SIL.WritingSystems.pdb"=>"lib/dotnet", "icu.net.dll"=>"lib/dotnet", "icudt54.dll"=>"lib/dotnet", "icuin54.dll"=>"lib/dotnet", "icuuc54.dll"=>"lib/dotnet"}
#     VCS: https://github.com/sillsdev/libpalaso.git []

# make sure output directories exist
mkdir -p ../build/
mkdir -p ../lib/dotnet

# download artifact dependencies
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/Palaso.BuildTasks.dll?branch=%3Cdefault%3E ../build/Palaso.BuildTasks.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/Ionic.Zip.dll?branch=%3Cdefault%3E ../lib/dotnet/Ionic.Zip.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/L10NSharp.dll?branch=%3Cdefault%3E ../lib/dotnet/L10NSharp.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/L10NSharp.pdb?branch=%3Cdefault%3E ../lib/dotnet/L10NSharp.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Core.dll?branch=%3Cdefault%3E ../lib/dotnet/SIL.Core.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Core.pdb?branch=%3Cdefault%3E ../lib/dotnet/SIL.Core.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.DblBundle.dll?branch=%3Cdefault%3E ../lib/dotnet/SIL.DblBundle.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.DblBundle.pdb?branch=%3Cdefault%3E ../lib/dotnet/SIL.DblBundle.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Media.dll?branch=%3Cdefault%3E ../lib/dotnet/SIL.Media.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Media.pdb?branch=%3Cdefault%3E ../lib/dotnet/SIL.Media.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Scripture.dll?branch=%3Cdefault%3E ../lib/dotnet/SIL.Scripture.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Scripture.pdb?branch=%3Cdefault%3E ../lib/dotnet/SIL.Scripture.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Windows.Forms.dll?branch=%3Cdefault%3E ../lib/dotnet/SIL.Windows.Forms.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Windows.Forms.pdb?branch=%3Cdefault%3E ../lib/dotnet/SIL.Windows.Forms.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Windows.Forms.DblBundle.dll?branch=%3Cdefault%3E ../lib/dotnet/SIL.Windows.Forms.DblBundle.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.Windows.Forms.DblBundle.pdb?branch=%3Cdefault%3E ../lib/dotnet/SIL.Windows.Forms.DblBundle.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.WritingSystems.dll?branch=%3Cdefault%3E ../lib/dotnet/SIL.WritingSystems.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/SIL.WritingSystems.pdb?branch=%3Cdefault%3E ../lib/dotnet/SIL.WritingSystems.pdb
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/icu.net.dll?branch=%3Cdefault%3E ../lib/dotnet/icu.net.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/icudt54.dll?branch=%3Cdefault%3E ../lib/dotnet/icudt54.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/icuin54.dll?branch=%3Cdefault%3E ../lib/dotnet/icuin54.dll
copy_auto http://build.palaso.org/guestAuth/repository/download/bt436/latest.lastSuccessful/icuuc54.dll?branch=%3Cdefault%3E ../lib/dotnet/icuuc54.dll
# End of script
