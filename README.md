# NLP Turkish Numeric Characters to Number Conversion API

This project is an ASP.NET Core MVC Web API that utilizes natural language processing (NLP) to convert numerical expressions written in Turkish text to numerical values.

## Usage

To run and develop the application, follow these steps:

1. **Setup Development Environment:**
   - Use [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) as your IDE.
   - Make sure you have [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) installed.


2. **Test the Web API:**
	- After running the project click to the POST INPUT that has been called as /api/Input/convert.
	- Click to the Try it out button which is located oppsite of the Parameters headers.
	- Use the Json block that is located below for testing.
	  
	  {
		 "UserText": "string"			
      }

	- The API will respond with the converted text:
	
	  {
  		 "Output": "ConvertedString"		
      }


3. **Project Structure**	
  The project includes the following main folders:

   - Controllers: Contains MVC and Web API controllers.
   - Models: Contains application models.
   - Method Details
   - To learn more about the main functionality of the project, refer to visit the InputController.cs file.

4. **Development Environment**		
   - .NET Core 7.0 or later is required.	
   - An IDE such as Visual Studio is recommended.	