// See https://aka.ms/new-console-template for more information
var log = NLog.LogManager.GetCurrentClassLogger();
log.Info("Leap Year Program Started");
leapYear run = new leapYear();
run.checkLeapYear();
