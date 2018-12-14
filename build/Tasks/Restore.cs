using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Restore;
using Cake.Frosting;

[Dependency(typeof(Clean))]
public class Restore : FrostingTask<Context>
{
    public override void Run(Context context)
    {
        context.DotNetCoreRestore("./src", new DotNetCoreRestoreSettings
        {
            MSBuildSettings = context.MSBuildSettings
        });
    }
}