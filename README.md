# FreshInk
This application keeps all listed printers' ink fresh by running a test job once every specified time interval.

Copy the Sample Test Files to: C:\Users\Public\Documents

To make the program run, follow these steps:
    1: Build the solution
    2: Copy the Sample Test Files to: C:\Users\Public\Documents
    3: Modify the TestConfig.json file with the test document to use for the print test. Using 'Default' will print an internally built test document.
    4: Modify the TestConfig.json file with the printer names to test.  To see a list of available printers to test, go to 'Printers & Scanners' in Windows settings and copy the printer name exactly as is into the json file.
    3: Open up the Windows Task Scheduler
    4: Click on 'Action' in toolbar and create a 'Basic Task'.
    5: Give the task the name of 'FreshInk'.  Do not use any spaces.  Description is optional.
    6: Give the task a trigger interval. Recommended interval is 'Daily' and set recur every 20 days.  This will run print test every 20 days.
    7: Set Action to 'Start a program'
    8: Provide the location of the FreshInk.exe

A future build intends to automate the setup of these steps, but for now must be done manually.