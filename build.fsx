#r "./CreateProcessAsUser.dll"

#if !FAKE
// there are some issues with FSI and .NET Standard 2.0
// see https://github.com/Microsoft/visualfsharp/issues/5216
#r "netstandard.dll"
#endif


murrayju.ProcessExtensions.ProcessExtensions.StartProcessAsCurrentUser(
    appPath = "calc.exe"
)
