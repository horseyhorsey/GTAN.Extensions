# GTAN.Extensions

Extending the GTAN Api with some helper methods

## Build directory (Shared)
	  <!--COPY FILES TO RAGEMP RUNTIME-->
	  <Target Name="PostBuild" AfterTargets="PostBuildEvent">
		<Exec Command="xcopy /E /Y /R &quot;$(TargetDir)*.*&quot; &quot;C:\RAGEMP\server-files\bridge\runtime\*.*&quot;&#xD;&#xA;del &quot;C:/RAGEMP\server-files\bridge\runtime\$(TargetName).deps.json&quot;" />
	  </Target>