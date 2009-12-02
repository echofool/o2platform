﻿namespace O2.Kernel.O2CmdShell
{
    public class ShellCommands
    {
        
        public static string hello()
        {
            sendMessage("in hello");
            return "World";
        }

        public static string sendMessage(string messageText)
        {            
            DI.o2MessageQueue.sendMessage(messageText);
            return "message sent: " + messageText;
        }

        public static string getName()
        {
            return DI.O2KernelProcessName;
        }

        public static void setName(string newName)
        {
            DI.O2KernelProcessName = newName;
        }

        public static void echo(string echoMessage)
        {
            if (DI.o2Shell != null)
                DI.o2Shell.shellIO.writeLine(echoMessage);
        }

        public static void appDomains()
        {
            DI.o2Shell.shellIO.writeLine("\nThere are {0} AppDomains currently hosted by this O2Kernel process", DI.appDomainsControledByO2Kernel.Count);
            foreach(var hostedAppDomains in DI.appDomainsControledByO2Kernel.Keys)
                DI.o2Shell.shellIO.writeLine("\t{0}", hostedAppDomains);
        }

        public static void filesInAppDomain(string appDomainName)
        {
            if (false == DI.appDomainsControledByO2Kernel.ContainsKey(appDomainName))
                DI.o2Shell.shellIO.writeLine("AppDomain not found {0}", appDomainName);
            {
                var assemblies = DI.appDomainsControledByO2Kernel[appDomainName].FilesInAppDomainBaseDirectory;
                DI.o2Shell.shellIO.writeLine("\nThere are {0} files in the AppDomain ", assemblies.Count , appDomainName);
                foreach(var assemblyName in assemblies)
                    DI.o2Shell.shellIO.writeLine("\t{0}", assemblyName);
            }
        }

    }
}
