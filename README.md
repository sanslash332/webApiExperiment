# webApiExperiment
A small work in ASP webapi2, to test the system.

#Current urls:

The small app, support currently three (technically two) small request:

First, a simple get to /, to show a minimalist page with some text.

second, with http Post content-type application/json, /word. The body, must have a data variable, with a string of 4 characters. returns the same json, but with the string upercased.

thirdth: get, to /time, with the time in HH:mm format, in the value variable on the query string. returns the same time, but with YYYY-MM-ddTHH:mm:ssZ format.
