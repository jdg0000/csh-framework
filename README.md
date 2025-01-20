CSH Framework

This project is a basic custom shell framework implemented in C#. It provides a command-line interface to execute simple shell-like commands such as echo, ls, cd, history, clear, and exit.

Features

The framework supports the following commands:
	1.	echo <message>
Prints the message to the console.
	2.	ls
Lists the files and directories in the current working directory.
	3.	cd <path>
Changes the current working directory to the specified path.
	4.	history
Displays a list of all previously entered commands during the session.
	5.	clear
Clears the console screen.
	6.	exit or quit
Exits the program.
	7.	Unknown Commands
If an unrecognized command is entered, the program will respond with unknown command.

How It Works
	1.	The program runs in an infinite loop, accepting user input.
	2.	Commands are matched using string checks to determine their type and corresponding functionality.
	3.	A history of commands is maintained and can be displayed using the history command.
	4.	Files and directories are managed using the System.IO namespace.

Getting Started

Prerequisites
	•	.NET SDK (6.0 or later)

Building the Project
	1.	Clone the repository.
	2.	Navigate to the project directory.
	3.	Build the project using:
  dotnet build

Running the compiled program:
dotnet run

Example Usage:

csh1> echo Hello, World!
Hello, World!
csh1> ls
/path/to/file1.txt
/path/to/file2.txt
/path/to/directory
csh1> cd /path/to/directory
csh1> history
echo Hello, World!
ls
cd /path/to/directory
csh1> exit

Contributing

Feel free to fork this repository and make improvements. Pull requests are welcome!

License

This project is licensed under the MIT License.
