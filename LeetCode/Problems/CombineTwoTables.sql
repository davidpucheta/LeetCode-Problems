﻿SELECT P.FirstName, P.LastName, A.City, A.State 
FROM Person P 
LEFT JOIN Address A 
On P.PersonId = A.PersonId