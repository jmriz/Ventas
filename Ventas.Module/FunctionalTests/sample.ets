;#DropDB VentasEasyTest

#Application VentasWin
;#Application VentasWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef VentasWin

*Action About...
 
*Action OK

#EndIf

#IfDef VentasWeb
*Action Navigation(My Details)
#EndIf
