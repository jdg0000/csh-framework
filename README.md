CSH Framework

This project is a basic custom shell framework implemented in C#. It provides a command-line interface to execute simple shell-like commands such as echo, ls, cd, history, clear, and exit.

Full documentation at nllfy.github.io/index.html, NOTE: do not forget the index.html otherwise it will show the old documentation 

Features

The framework supports the following commands:

output the message given to the console

		echo <message>

Lists the files and directories in the current working directory.

		ls

Changes the current working directory to the specified path.

		cd <path>

Displays a list of all previously entered commands during the session.

		history

Clears the console screen.

		clear

Exits the program.

		exit or quit

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

or download the installer or the executable from the releases NOTE: the mac executable works on linux

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
