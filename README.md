
# Blazor website for documentations



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