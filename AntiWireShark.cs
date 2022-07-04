foreach (Process wiresharkProcess in Process.GetProcessesByName("Wireshark"))
                wiresharkProcess.Kill();