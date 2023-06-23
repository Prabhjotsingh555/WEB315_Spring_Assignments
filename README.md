first i make a new repository with Readme file
then i open this visual
update visual
for clone repository
install git
instal c# extension
open repository and choose this location in pc i choose desktop for easily find
make a file with .gitignore
write bin and obj inside the above file
then i run command ( dotnet new webapp -o cars--framework net5.0 )
do some changes like theme name Welcome message and time in Index.cshtml file under Pages
then i create folder under Pages with name Models 
create file with name cars1.cs under Models under Pages
then run next command
copy the code from course material and paste it in cars1.cs file
then run the command ( dotnet-aspnet-codegenerator razorpage -m cars1 -dc carsContext -udl -outDir Pages/cars1 --referenceScriptLibraries -sqlite) after doing some changes like change name from movies to cars1 two time
this make a folder with same name
then i run next two commands at once first was dotnet ef migrations add InitialCreate and second was dotnet ef database update
then i make a file with name SeedData.cs and copy the data which i get from course material
did some changes make 6 propertiies of six cars
copy the last data from course material and paste in program.cs folder and change the name
in last make a new button under Pages > Shared > layout 
finally i run the command dotnet run
first get error which was project not found
then i dir see project 
copy name write cd and paste name then run
so now when i run dotnet run my project is building and it give me a local browser address
when i click on it by pressing ctrl + click it take me at browser from visual
now my webite is running

----------------------Assignment 2------------

First i create new Branch with name Assignment 2
i commited data
then i run comman (Dir > cd cars > Dotnet watch run)
now my file work well
now i add two new properties in cars1.cs folder
properties are Rating and Colour
i commited data
then i update all pages which are under cars1 folder Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml and Index.cshtml
i commited data
updated SeedData page 
i commited data
then i run these commands > dotnet tool install --global dotnet-ef --version 5
>> dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
>> dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
>> dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
>> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
>> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

> dotnet ef migrations add Colour  for add colour
> dotnet ef migrations add Rating  for add Rating

 first i deleted db folder
 then i run this command > dotnet ef database update     for update data

and in last > dotnet watch run 
now my updating pge section is done

now i update these pages cars1.cs ,Index.cshtml ,Index.cshtml.cs for adding search field

after this i deleted db folder
 then i run this command > dotnet ef database update     for update data

 now my search field is also done

 in the last step i updated only cars1.cs page for adding validation  
 after adding validation i deleted db folder
 then i run this command > dotnet ef database update     for update data

so now my all steps are done so i run > dotnet watch run command and test my webapp which is working good