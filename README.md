
# Blazor website for documentations


## Adding a new documentation


### Adding item to the home page

Under Services/PackageRepository.cs, under the initialization of ```public static IEnumerable<Package> All```,
make sure make sure to add the following:

```csharp
new(){
    Name = "MyNugetName",
    Description = "Describing the documentation",
    GitRepo = "MyGitRepo",  
    IsDisplayed = true, 
    HasDocumentation = true, 
}
```

This makes sure the documentation is added the the home page.

- **Name** Name to be displayed for the documentation.
This is also taken as the nuget package name under https://www.nuget.org/packages.
This base address can be changed from Models/Package.cs, the `NugetUrl` property
- **Description** Description displayed for the documentation
- **GitRepo** The git repository under https://github.com/neville-nazerane.
If no git repo, this field can be left as NULL
This base address can be changed from Models/Package.cs, the `GitUrl` property
- **IsDisplayed** If false, the documentation is not shown on the home page. 
This can be set to false if a new documentation is being setup but not yet ready to be published
- **HasDocumentation** If false, a link to a documentation is omitted. 
This can be used to display the documentation and link it to the git/nuget page before the documentations are available.

### Adding the documentation page

1. As a standard, make sure to create a new folder under Pages/Documentation
with the page name being the nuget name with periods replaced with underscores.
For instance, if the nuget name is MyLib.Core, the folder would be MyLib_Core.

2. Under the new folder, create a file named `_Base_Page.razor`. This file is responsible to stitch up all sections

3. Ensure the first line of the page defines the route in the format /documentation/<folder name>.

```csharp
@page "/documentation/MyLib_Core"
```

4. As a standrd, for each MainSection (more on main sections below), 
add a new .razor file under the current folder and add a reference to the file in _Base_Page.razor. For instance, for the introduction section, a new file named **Introduction.razor** can be created with the following code added in the _Base_Page.razor file:

```xml
<Introduction />
```


## Sample code using the blazor components 


**MainSection**

Creates the main sections of a documentation page. 
Gets included in the nav bar and in the main body

- **Heading:** The text shown on the nav bar and as a heading in the document for the section
- **Id** The unique id that would used for navigation
- **Icon** Font awesome icon for the nav menu
- **Description** Description of the section that won't be linked to nav


**SubSection**

Expected to go into the content of the main section. 
Gets included as a sub-section in the nav bar and main body.

- **Id** The unique id that would used for navigation
- **Heading:** The text shown on the nav bar and as a heading in the document for the section



```html
<MainSection Heading="Main Heading" Id="myid" Icon="fa-info">

    <Description>
        Description for the current main section
    </Description>

    <Content>

        <SubSection Id="subId" Heading="Sub Section 1">

            <p>Explanation of code</p>

            <CodeBlock CodeClass="bash">
                dotnet run
            </CodeBlock>

        </SubSection>


        <SubSection Id="subId2" Heading="Sub Section 2">

            <p>C# code</p>

            <CSharp>
                Console.WriteLine("Stuff"):
            </CSharp>

        </SubSection>

    </Content>

</MainSection>
```