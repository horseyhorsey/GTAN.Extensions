# GTAN.Data

Data for the game.

- Interiors
- Vehicles dicts
- Ped dicts
- Outfits
- Locations
- Etc

## Notes

- Outfits jsons copied to bridge folder

## Build directory (Shared)
	  <!--COPY FILES TO RAGEMP RUNTIME-->
	  <Target Name="PostBuild" AfterTargets="PostBuildEvent">
		<Exec Command="xcopy /E /Y /R &quot;$(TargetDir)*.*&quot; &quot;C:\RAGEMP\server-files\bridge\runtime\*.*&quot;&#xD;&#xA;del &quot;C:/RAGEMP\server-files\bridge\runtime\$(TargetName).deps.json&quot;" />
	  </Target>