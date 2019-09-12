# Parse the 'apispec.html' in the 'VulkanSDK/../Documentation' folder.
There are Enums, Handles, Flags, PFNs, Structs and Commands listed in the big file 'apispec.html'.  
This project 'ApiSpec' parses the file and dump all those types above into C# files.  
Apparently, the 'apispec.html' is not 100% (maybe only 99.9%) complete.  
Thus, some manual modifications are carried out after dumping them.  
I'll leave this project here for infrequent affairs, for example, when a new version of Vulkan is announced.  
