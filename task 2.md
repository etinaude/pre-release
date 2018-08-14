**2.1 / 2.2**
```
01 	job_status(sally, employed)
02	job_status(alex, unemployed)
03	job_status(steven, employed)
04	job_status(mary, unemployed)
05	job_status(bill, unemployed)
06	first_aid_trained(sally)
07	first_aid_trained(bill)
08	years_experience(sally, 5)
09	years_experience(bill, 15)
10	years_experience(Alex, 12)
11	years_experience(steven, 20)
12	years_experience(mary, 0)
13	qualified_as(sally, doctor)
14	qualified_as(bill, maths_teacher)
15	qualified_as(alex, typist)
16	qualified_as(alex, accountant)
17	qualified_as(mary, prostitute)
18	qualified_as(mary, quantum_physicist)
19	qualified_as(steven, manager)
20	job_vacancy(autoshop, mechanic)
21 	job_vacancy(a_school, maths_teacher)
22	job_vacancy(k_road, prostitute)
23	job_vacancy(Briscoes, web_fulfilment_assistant)
24	job_vacancy(raw_essentails, animal_neutrition_specailist)
25	job_vacancy(casio, manager)
26	suitable_job(X, Y)	IF job_status(X, unemployed) AND qualified_as(X, Z) AND Job_vacancy(Y, Z)
```
**2.3**
```
doctor
sally
NULL
NULL
```
**2.4**
```
01	employed(X)	IF jobstatus(X, employed)
02	Trained(Y)		IF first_aid_trained(Y)
03 	late_nights(Z)	IF qualified(Z, Prostitute)
04 	school_staff(V)	IF vacancy(a_school, V)
05 	Math_nerd(W)	IF vacancy(W, math_teacher)
06	Suited(H)		IF qualified_as(sally, H) OR qualified_as(alex, H) 
```
**2.5**
```
01	Hire(X)		IF qualified_as(X, mechanic) AND (years_experience(X, 5) OR first_aid_trained(X))
```
