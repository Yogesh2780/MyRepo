This solution has 3 project
OnlineTest.API
OnlineTest.UI
OnlineTest.Test


KeyPoints
SearchManager - Contains login


The API contaiins Business folder inside that a class SeriesManager has the logic

GenerateSeries - accepting a parameter maxLength, based on that its generating series.

Search - This method is finding the number divisible by the divident at the correct position


UI contains a index view to get input parameter- divisor, number and series length.
On click of submit button SearchNumber method of Homecontroller being called whic is connecting to WEB API controller SeriesController and calling  Methods to get the Required number.


Limitation/Constraint

The result will be 0 if the no number is found in the series for given in.put
the result will be 0 if maxLength is 0 to generate the series

The API need to  running before testing this api. Best to host in IIS.


