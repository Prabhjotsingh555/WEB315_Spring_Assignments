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