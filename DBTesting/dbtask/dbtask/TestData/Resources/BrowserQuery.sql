Select Count(test.name) As Browsers from test where browser = 'Chrome'
Union 
Select Count(test.name) from test where browser = 'FireFox'