internal class Program
{
    private static void Main(string[] args)
    {
        /*Tarea1*/
        int i;
        int opcion;
        empleado [] empleados = new empleado[5];
        do{
            Console.WriteLine("-La opcion 1 para insertar los datos\n-La opcion 2 para mostrar los datos:\n-para salir 3");
            Console.WriteLine("Ingresa una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion){
                case 1: 
                    for (i=0;i<5;i++){
                    Console.WriteLine("Ingresa el nombre:");
                    empleados[i].nombre=Console.ReadLine();
                    Console.WriteLine("Ingresa la edad:");
                    empleados[i].edad=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el salario:");
                    empleados[i].slario=Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Ingresa el nombre de la empresa:");
                    empleados[i].nombreEmpresa=Console.ReadLine();
                    }
                    break;
                case 2:
                    for (i=0;i<5;i++){
                    Console.WriteLine("El nombre es {0}, la edad es {1} ,el salario es {2} ,el nombre de la empresa es {3}",empleados[i].nombre,empleados[i].edad,empleados[i].slario,empleados[i].nombreEmpresa);
                    }
                    break;
                case 3:
                    Console.WriteLine("Finalizado de programma");
                    opcion=0;
                    break;
            }
        }while(opcion !=0);
        /*Tarea2*/
        Producto [,] Supermercado = new Producto [2,5];
        int i,j;
        int comptadorA=0;
        int comptadorB=0;
        int opcion;
        int opcionCategoria,opcionCantidad,CantidadTotal=0,opcionImporte;
        float ImporteTotal=0;
        for (i=0;i<2;i++){
            for (j=0;j<5;j++){
                if (Supermercado[i,j].nombre!=null && i==0) {
                    comptadorA++;
                }
                else if (Supermercado[i,j].nombre!=null && i==1) {
                    comptadorB++;
                }
            }
        }
        Console.WriteLine("Hay {0} productos de categoria alimentacion y {1} de otras categorias",comptadorA,comptadorB);
        for (i=0;i<2;i++){
            Console.WriteLine("la categoria {0}",i+1);
            for (j=0;j<5;j++){
                Console.WriteLine("Ingresa el nombre del producto:");
                Supermercado[i,j].nombre=Console.ReadLine();
                Console.WriteLine("Ingresa el precio:");
                Supermercado[i,j].precio=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingresa la cantidad:");
                Supermercado[i,j].cantidad=Convert.ToInt32(Console.ReadLine());
                if (i==0){
                    Supermercado[i,j].categoria=true;
                }
                else{
                    Supermercado[i,j].categoria=false;
                }
            }
        }
        do{
            Console.WriteLine("1-Para mostrar los datos de cada categoria\n2-Para calcular el importe total de los categorias\n3-Para calcular el total de los productos de las categorias.\n4-Para salir");
            opcion=Convert.ToInt32(Console.ReadLine());
            switch (opcion){
            case 1: Console.WriteLine("Mostrar los datos de cada categoria.\n1-Alimentacion 2-general");
                    do{
                        Console.WriteLine("Ingresa la categoria:");
                        opcionCategoria=Convert.ToInt32(Console.ReadLine());
                    }while(opcionCategoria<1 || opcionCategoria>2);
                    if(opcionCategoria==1){
                        for (j=0;j<5;j++){
                            Console.WriteLine("el nombre es {0}, el precio es {1}, la cantidad es {2} y la categoria es ALimentacion",Supermercado[0,j].nombre,Supermercado[0,j].precio,Supermercado[0,j].cantidad);
                        }
                    }   
                    else{
                        for (j=0;j<5;j++){
                            Console.WriteLine("el nombre es {0}, el precio es {1}, la cantidad es {2} y la categoria general.",Supermercado[1,j].nombre,Supermercado[1,j].precio,Supermercado[1,j].cantidad);
                        }
                    }
                    break;
            case 2: Console.WriteLine("El importe total de los categorias:1-Alimentacion 2-general");
                    do{
                        Console.WriteLine("Ingresa la categoria:");
                        opcionImporte=Convert.ToInt32(Console.ReadLine());
                    }while(opcionImporte<1 || opcionImporte>2);
                    if(opcionImporte==1){
                        for(j=0;j<5;j++){
                        ImporteTotal=0;
                            ImporteTotal+=Supermercado[0,j].precio*Supermercado[0,j].cantidad;
                            Console.WriteLine("el importe del producto {0} es {1}",Supermercado[0,j].nombre,ImporteTotal);
                        }
                    }
                    else{
                        for(j=0;j<5;j++){
                            ImporteTotal=0;
                            ImporteTotal+=Supermercado[1,j].precio*Supermercado[1,j].cantidad;
                            Console.WriteLine("el importe del producto {0} es {1}",Supermercado[1,j].nombre,ImporteTotal);
                        }
                    }
                    break;
            case 3: Console.WriteLine("El total de los productos de las categorias:1-Alimentacion 2-general");
                    do{
                        Console.WriteLine("Ingresa la categoria:");
                        opcionCantidad=Convert.ToInt32(Console.ReadLine());
                    }while(opcionCantidad<1 || opcionCantidad>2);
                    if (opcionCantidad==1){
                         CantidadTotal = 0;
                        for(j=0;j<5;j++){
                            CantidadTotal+=Supermercado[0,j].cantidad;
                        }
                        Console.WriteLine("la cantidad total de los productos de la categoria Alimentacion  es {0}",CantidadTotal);
                    }
                    else{
                         CantidadTotal = 0;
                        for(j=0;j<5;j++){
                            CantidadTotal+=Supermercado[1,j].cantidad;
                        }
                        Console.WriteLine("la cantidad total de los productos de la otra categoria es {0}",CantidadTotal);
                    }
                    break;
            default: Console.WriteLine("Finalizacion de programma");
                    opcion=0;
                    break;

        } 
        }while(opcion!=0);
        /*Tarea3*/
        int i;
        Empleado[] Empleados = new Empleado[3];
        for (i=0;i<3;i++){
            Console.WriteLine("Ingresa el nombre:");
            Empleados[i].nombre=Console.ReadLine();
            Console.WriteLine("Ingresa la edad:");
            Empleados[i].edad=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el salario:");
            Empleados[i].salario=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingresa la calle:");
            Empleados[i].direccion.calle=Console.ReadLine();
            Console.WriteLine("Ingresa la ciudad:");
            Empleados[i].direccion.ciudad=Console.ReadLine();
            Console.WriteLine("Ingresa el codigo postal:");
            Empleados[i].direccion.codigoPostal=Convert.ToInt32(Console.ReadLine());
        }
        foreach (var empleado in Empleados){
            Console.WriteLine("Nombre:{0}\nEdad:{1}\nSalario:{2}\nDireccion:\nCalle:{3},Ciudad:{4},Codigo Postal:{5}",empleado.nombre,empleado.edad,empleado.salario,empleado.direccion.calle,empleado.direccion.ciudad,empleado.direccion.codigoPostal);
        }
        /*Tarea4*/
        int i, j, opcion, opcionAgregar, opcionImporte, opcionCantidad;
        float ImporteTotal ;
        int CantidadTotal ;
        Productos[,] SuperMercado = new Productos[2, 5];
        int comptadorA ;
        int comptadorB ;
        do
        {
            Console.WriteLine("1-Para Agregar un producto de Alimentación\n2-Para Agregar un producto de General\n3-Para mostrar todos los productos de Alimentación\n4-Para mostrar todos los productos de General\n5-Para Calcular el Importe Total de los Productos\n6-Para calcular la cantidad Total de los Productos\n7-Para salir");
            Console.WriteLine("Ingresa una opción:");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    comptadorA = 0; /* Este comptador para calcular cuantos productos de alimentacion hay*/
                    for(j=0;j<5;j++){
                        if (SuperMercado[0, j].nombre != null){
                            comptadorA++;
                        }
                    }
                    Console.WriteLine("La cantidad de productos de Alimentación es {0}", comptadorA);
                    do
                    {
                        Console.WriteLine("Cuantos productos de Alimentación quieres agregar? ({0} como máximo)", 5 - comptadorA); /*Preguntamos cuantos productos de alimentacion queremos agregar,
                                                                                                                                        la operacion 5- comptadorA nos dice cuantos productos de alimentacion hay
                                                                                                                                        para que el usuario no sobrepase el limite de 5 productos*/
                        opcionAgregar = Convert.ToInt32(Console.ReadLine());
                    } while (opcionAgregar > 5-comptadorA); 

                    for (j = comptadorA; j < opcionAgregar+comptadorA; j++) /*el variable j empieza con el valor comptadorA,para que no boramos otros productos de alimentacion,
                                                                            por ejemplo en la primera vez, si el usuario ha introducido 2 productos de alimentacion, j empieza en 
                                                                            la posicion 2, y llega hasta la posicion opcionAgregar+comptadorA, para que no sobrepase el limite de 5*/
                    {
                        Console.WriteLine("Ingresa el nombre del producto:");
                        SuperMercado[0, j].nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa el precio del producto:");
                        SuperMercado[0, j].precio = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Ingresa la cantidad del producto:");
                        SuperMercado[0, j].cantidad = Convert.ToInt32(Console.ReadLine());
                        SuperMercado[0, j].categoria = "Alimentación";
                    }
                    break;

                case 2:
                    comptadorB = 0;
                    for(j=0;j<5;j++){
                        if (SuperMercado[1, j].nombre != null){
                            comptadorB++;
                        }
                    }
                    Console.WriteLine("La cantidad de productos de la categoria General es {0}", comptadorB);
                    do
                    {
                        Console.WriteLine("Cuantos productos de General quieres agregar? ({0} como máximo)", 5 - comptadorB);
                        opcionAgregar = Convert.ToInt32(Console.ReadLine());
                    } while (opcionAgregar > 5-comptadorB);

                    for (j = comptadorB; j < opcionAgregar+comptadorB; j++)
                    {
                        Console.WriteLine("Ingresa el nombre del producto:");
                        SuperMercado[1, j].nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa el precio del producto:");
                        SuperMercado[1, j].precio = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Ingresa la cantidad del producto:");
                        SuperMercado[1, j].cantidad = Convert.ToInt32(Console.ReadLine());
                        SuperMercado[1, j].categoria = "General";
                    }
                    break;

                case 3:
                    Console.WriteLine("Los Productos de Alimentación son:");
                    for (j = 0; j < 5; j++)
                    {
                        Console.WriteLine("El Producto {0}:\nnombre: {1}\nprecio: {2}\ncantidad: {3}", j + 1, SuperMercado[0, j].nombre, SuperMercado[0, j].precio, SuperMercado[0, j].cantidad);
                    }
                    break;

                case 4:
                    Console.WriteLine("Los Productos de la categoría General son:");
                    for (j = 0; j < 5; j++)
                    {
                        Console.WriteLine("El Producto {0}:\nnombre: {1}\nprecio: {2}\ncantidad: {3}", j + 1, SuperMercado[1, j].nombre, SuperMercado[1, j].precio, SuperMercado[1, j].cantidad);
                    }
                    break;

                case 5:
                    Console.WriteLine("El importe total de las categorías: 1-Alimentación 2-General");
                    do
                    {
                        Console.WriteLine("Ingresa la categoría:");
                        opcionImporte = Convert.ToInt32(Console.ReadLine());
                    } while (opcionImporte < 1 || opcionImporte > 2);

                    if (opcionImporte == 1)
                    {
                     
                        for(j=0;j<5;j++){
                            ImporteTotal = 0;
                            ImporteTotal+=SuperMercado[0,j].precio*SuperMercado[0,j].cantidad;
                            Console.WriteLine("el importe del producto {0} es {1}",SuperMercado[0,j].nombre,ImporteTotal);

                        }
                    }
                    else
                    {
                        for (j = 0; j < 5; j++)
                        {
                            ImporteTotal = 0;
                            ImporteTotal += SuperMercado[1, j].precio * SuperMercado[1, j].cantidad;
                            Console.WriteLine("El importe total del Producto {0} de la  categoría General es: {1}", SuperMercado[1, j].nombre, ImporteTotal);
                        }
                    }
                    break;

                case 6:
                    Console.WriteLine("Cantidad Total de los Productos: 1-Alimentación 2-General");
                    do
                    {
                        Console.WriteLine("Ingresa la categoría:");
                        opcionCantidad = Convert.ToInt32(Console.ReadLine());
                    } while (opcionCantidad < 1 || opcionCantidad > 2);

                    if (opcionCantidad == 1)
                    {
                        CantidadTotal = 0; 
                        for (j = 0; j < 5; j++)
                        {
                            CantidadTotal += SuperMercado[0, j].cantidad;
                        }
                        Console.WriteLine("La cantidad total de los Productos de la categoría Alimentación es: {0}", CantidadTotal);
                    }
                    else
                    {
                        CantidadTotal = 0; 
                        for (j = 0; j < 5; j++)
                        {
                            CantidadTotal += SuperMercado[1, j].cantidad;
                        }
                        Console.WriteLine("La cantidad total de los Productos de la categoría General es: {0}", CantidadTotal);
                    }
                    break;

                default:
                    Console.WriteLine("Finalización del programa");
                    break;
            }

        } while (opcion != 7);
        /*Tarea5*/
        bool [] asientosTeatro=new bool [10];
        Reserva [] reservas = new Reserva[5];
        int i,j,opcion,opcionReserva,comptadorReservas,numeroAsiento,comptadorAsientos;
        for(i=0;i<=9;i++){
            asientosTeatro[i]=false; /*Para indecar que los asientos estan libres*/
        }
        do{
           Console.WriteLine("1-Para realiza Reservas.\n2-Para mostrar el estado de los asientos.\n3-Para mostrar los reservas realizadas.\n4-Salir.");
           Console.WriteLine("Ingresa una opcion:");
           opcion=Convert.ToInt32(Console.ReadLine());
           switch (opcion){
                    case 1: /* Para realizar Reservas */
                        comptadorReservas = 0;
                        for (i = 0; i < 5; i++)
                        {
                            if (reservas[i].nombreCliente != null)
                            {
                                comptadorReservas++;
                            }
                        }
                        Console.WriteLine("Hay {0} reservas realizadas, y {1} libres", comptadorReservas, 5 - comptadorReservas);
                        do
                        {
                            Console.WriteLine("¿Cuántas Reservas Quieres Hacer? ({0} como máximo)", 5 - comptadorReservas);
                            opcionReserva = Convert.ToInt32(Console.ReadLine());
                        } while (opcionReserva < 0 || opcionReserva > 5 - comptadorReservas); /* Para que no se puedan hacer más de 5 reservas */
                        for (i = comptadorReservas; i < opcionReserva + comptadorReservas; i++)
                        {
                            Console.WriteLine("Ingresa el nombre del cliente:");
                            reservas[i].nombreCliente = Console.ReadLine();
                            Console.WriteLine("Ingresa el apellido del cliente:");
                            reservas[i].apellidoCliente = Console.ReadLine();
                            Console.WriteLine("Ingresa el número de teléfono:");
                            reservas[i].NumeroTelefono = Convert.ToInt32(Console.ReadLine());
                            comptadorAsientos = 0;
                            for (j = 0; j < 10; j++)
                            {
                                if (asientosTeatro[j] == true)
                                { /* Para contar cuántos asientos están libres */
                                    comptadorAsientos++;
                                }
                            }
                            Console.WriteLine("Hay {0} asientos libres", 10 - comptadorAsientos);
                            do
                            {
                                Console.WriteLine("Ingresa cuántos asientos quieres:");
                                numeroAsiento = Convert.ToInt32(Console.ReadLine());
                            } while (numeroAsiento > 10 - comptadorAsientos);
                            for (j = comptadorAsientos; j < numeroAsiento + comptadorAsientos; j++)
                            {
                                asientosTeatro[j] = true;
                            }
                        }
                        break;
                    case 2: /*Para mostrar el estado de los asientos*/
                            for(i=0;i<10;i++){
                                if(asientosTeatro[i]==true){
                                    Console.WriteLine("el asiento {0} esta ocupado",i+1);
                                }
                                else{
                                    Console.WriteLine("el asiento {0} esta libre",i+1);
                                }
                            }
                            break;
                    case 3: /*Para mostrar las reservas*/
                            Console.WriteLine("Las reservas son: ");
                            for(i=0;i<5;i++){
                                if(reservas[i].nombreCliente!=null){
                                    Console.WriteLine("el cliente {0} {1} con el telefono {2}",reservas[i].nombreCliente,reservas[i].apellidoCliente,reservas[i].NumeroTelefono);
                                }
                            }
                            break;
                    default: Console.WriteLine("Finalización del programa");
                            opcion=0;
                            break;
                        
            }

        }while(opcion!=0); 
    }
        




}
    // /*Tarea1*/
    struct empleado {
        public string nombre;
        public int edad;
        public float slario;
        public string nombreEmpresa;
    }
    /*Tarea2*/
    struct Producto {
        public string nombre;
        public float precio;
        public int cantidad;
        public bool categoria;
    }
    /*Tarea3*/
    struct Empleado{
        public string nombre;
        public int edad;
        public float salario;
        public Direccion direccion;
        public struct Direccion{
            public string calle;
            public string ciudad;
            public int codigoPostal;
        }
        
    }
    /*Tarea4*/
    struct Productos{
        public string nombre;
        public float precio;
        public int cantidad;
        public string categoria;
    }
    /*Tarea5*/
    struct Reserva{
        public string nombreCliente;
        public string apellidoCliente;
        public float NumeroTelefono;
    }
     

