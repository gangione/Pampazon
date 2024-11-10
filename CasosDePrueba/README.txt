Aclaraciones del Proyecto Pampazon para Testing:

1. Para iniciar el sistema con los datos de Prueba:

	Correr el programa ejecutando el método CargarDatabaseTest() en el Program.cs;

	Esto hará que el sistema lea siempre que se ejecute los datos de la carpeta Almacenes/DatosDePrueba
	y grabando SIEMPRE los datos en la ejecución: Carpeta .bin.

	Clientes.
	Transportistas.
	Mercaderías en Stock para clientes 1 y 2.

	Cada vez que se ejecute el programa con este método se volverán a cargar los datos que tengan los archivos de la 
	carpeta antes mencionada y se podrán ejecutar distintos tipos de casos de prueba para el flujo completo 
	jugando con los datos de esa carpeta.

	Al finalizar los testeos se puede verificar los resultados de las pruebas realizadas en la ejecución
	con los archivos .json del bin (recomendable limpiar los archivos del bin luego de cada prueba).

	Si se necesita iniciar el testing con una carga de datos particular, se debe modificar el método CargarDatabaseTest()
	Ejecutando la lectura de los archivos específicos que hayan generado un caso particular que necesite un testing más exhaustivo.

	Ejemplo: Si cargamos varias OP que cuando las juntamos en una OS genera un error al Seleccionar la Mercadería podemos:

	Modificar el CargarDatabaseTest() para leer los datos cargados en la ejecución anterior:
	
	OrdenDePreparacionAlmacen.Leer()
	OrdenDeSeleccionAlmacen.Leer()

2. Para iniciar el sistema en modo productivo con datos iniciales y que este persista sus datos a pesar de finalizar 
su ejecución:

	Limpiar los datos de Prueba de la carpeta Almacenes/DatosDePrueba con los que se utilizarán en el 
	ambiente productivo.

	Correr el programa por primera vez ejecutando el método MigrarDatabaseInicial().
	Finalizar la ejecución del programa.

	Luego de la primera ejecución, remover MigrarDatabaseInicial() del Program y ejecutar CargarDatabaseProd().