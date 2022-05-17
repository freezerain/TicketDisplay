This project will show scanned articles 
for each ticket created in TPV window of a3erp
Author: Ilia Rodikov
Company: SGE
Date: 27.04.2022

How to build: 
1a) Change build directory of the project to valid path(same as in "How to use" section)
1b) Alternativly build in any folder and then move DLL to valid path root
2) Make sure target CPU is x86

How to use:
1) Put dll to valid path "<directorioERP>\Extensiones\SGE\TicketDisplay\Binarios"
2) Register DLL in database using SQL View (code in "SQL_View_DLL_Register" file of this project) for each company that  wants to use it.
3) Put Regasm assembly file  (RegDlls.ini of this project) in same folder 