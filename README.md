# CommandExecutor
Hi.This is Ali Mohammadi.
This class library can execute input commands and call every function you want.Just like CMD, It help you to build app like CMD or a command console.

How we can use it?:
You just need to make an instance of "Executer" class and call "AddCommand()" to enter your own command name and function, Then call "Execute()" and give it and input.
----
For example:
  Executer ex = new Executer();
  ex.AddCommand("Call Function",Myfunction);
  
  ex.Execute("MY INPUT");
  
:Now if we place "Call Function" , "CallFunction" or even "call function" instead of "MY INPUT" , Myfunction method will call.
----
CrossDeve.
My email: alimohammady0921@gmail.com
