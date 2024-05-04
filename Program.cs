
internal class Program
{
    static string nombreequipo="SU EQUIPO";
    static int marcoX1 = 0, marcoY1 = 7, marcoX2 = 50, marcoY2 = 27;

    private static void Main(string[] args)
    {    
        Console.CursorVisible = false;
       intro();
        bool salida = true;
        do
        {
            int opcion = menu_principal();
            switch (opcion)
            {
                case 0:
                    Jugar();
                    break;
                case 1:
                    reglas();
                    break;
                case 2:
                    MostrarEscenarios();
                    break;
                case 3:
                    salir_creditos(); salida = false;
                    break;
            }
        } while (salida);
      
    }
    //intro
    static void intro()
    {
        string a = """  _______          _________ _______     _______  _______  _______  _ """;
        string b = """ (  ___  )|\     /|\__   __// ___   )   (  ____ \(  ___  )(  ___  )( \ """;
        string c = """ | (   ) || )   ( |   ) (   \/   )  |   | (    \/| (   ) || (   ) || ( """;
        string d = """ | |   | || |   | |   | |       /   )   | |      | |   | || (___) || | """;
        string e = """ | |   | || |   | |   | |      /   /    | | ____ | |   | ||  ___  || | """;
        string f = """ | | /\| || |   | |   | |     /   /     | | \_  )| |   | || (   ) || | """;
        string g = """ | (_\ \ || (___) |___) (___ /   (_/\   | (___) || (___) || )   ( || (____/\ """;
        string h = """ (____\/_)(_______)\_______/(_______/   (_______)(_______)|/     \|(_______/ """;

        Thread.Sleep(300); Console.SetCursorPosition(24, 5); Console.WriteLine(a);
        Thread.Sleep(150); Console.SetCursorPosition(24, 6); Console.WriteLine(b);
        Thread.Sleep(300); Console.SetCursorPosition(24, 7); Console.WriteLine(c);
        Thread.Sleep(150); Console.SetCursorPosition(24, 8); Console.WriteLine(d);
        Thread.Sleep(300); Console.SetCursorPosition(24, 9); Console.WriteLine(e);
        Thread.Sleep(150); Console.SetCursorPosition(24, 10); Console.WriteLine(f);
        Thread.Sleep(300); Console.SetCursorPosition(24, 11); Console.WriteLine(g);
        Thread.Sleep(150); Console.SetCursorPosition(24, 12); Console.WriteLine(h);
        Thread.Sleep(2000);

        //variables a utilizar
        bool salida = true;
        string linea = "|";
        int sum = 0;
        int movd = 24;

        //Mensaje en pantalla
        Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(43, 16); Console.WriteLine("(Presione ESPACIO para continuar)");
        Thread.Sleep(200);

        //bucle
        do
        {
            //resetear el bucle
            if (sum > 20)
            {
                sum = 0;
                Console.Clear();
            }
            else
                sum++;


            //para que el mensaje no se borre en la consola
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(43, 16); Console.WriteLine("(Presione ESPACIO para continuar)");

            //Salir del bucle y de la presentación
            if (Console.KeyAvailable) //Lee si hay una tecla presionada
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar) //Compara si la tecla es "espacio" (el true es para que no muestre la tecla en consola)
                    salida = false; //Cierra el bucle


            //Lineas que caen
            color_txt_ran(); Console.SetCursorPosition(5, sum); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(15, sum + 3); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(25, sum + 1); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(35, sum + 4); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(45, sum); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(65, sum + 2); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(75, sum + 4); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(85, sum); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(95, sum + 2); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(105, sum + 2); Console.WriteLine(linea);
            color_txt_ran(); Console.SetCursorPosition(115, sum + 2); Console.WriteLine(linea);



            //Theme&Tittle
            color_txt_ran();
            Console.Beep(200, 50); Thread.Sleep(100); Console.SetCursorPosition(movd, 5); Console.WriteLine(a);
            color_txt_ran();
            Console.Beep(600, 50); Thread.Sleep(100); Console.SetCursorPosition(movd, 11); Console.WriteLine(g);
            color_txt_ran();
            Console.Beep(400, 50); Thread.Sleep(100); Console.SetCursorPosition(movd, 7); Console.WriteLine(c);
            color_txt_ran();
            Console.Beep(300, 50); Thread.Sleep(100); Console.SetCursorPosition(movd, 9); Console.WriteLine(e);
            color_txt_ran();
            Console.Beep(200, 50); Thread.Sleep(100); Console.SetCursorPosition(24, 8); Console.WriteLine(d);
            color_txt_ran();
            Console.Beep(600, 50); Thread.Sleep(100); Console.SetCursorPosition(24, 10); Console.WriteLine(f);
            color_txt_ran();
            Console.Beep(400, 50); Thread.Sleep(100); Console.SetCursorPosition(24, 6); Console.WriteLine(b);
            color_txt_ran();
            Console.Beep(300, 50); Thread.Sleep(100); Console.SetCursorPosition(24, 12); Console.WriteLine(h);

            //movimiento las letras horizontalmente
            if (movd == 25)
                movd--;
            else
                movd++;

        } while (salida);

        //aquí no ha pasado nada
        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }
    //funcion del menú principal
    static int menu_principal()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //variables a utilizar
        int cont = 0, x = 37, y = 1, alto = 20, ancho = 40;
        //creacion del marco
        while (cont < ancho)
        {
            Console.SetCursorPosition(x + cont, y);
            Console.Write("▀");
            Console.SetCursorPosition(x + cont, y + alto);
            Console.Write("▄");
            cont++;
        }
        cont = 0;
        while (cont <= alto)
        {
            Console.SetCursorPosition(x, y + cont);
            Console.Write("█");
            Console.SetCursorPosition(x + ancho, y + cont);
            Console.Write("█");
            cont++;
        }
        //mostrar letra "menu" con beep
        Console.Beep(300, 100); Thread.Sleep(150); Console.SetCursorPosition(45, 3); Console.WriteLine(" _____ _____ ___ _ __ __ ");
        Console.Beep(250, 100); Thread.Sleep(150); Console.SetCursorPosition(45, 4); Console.WriteLine("|█████|   __|███|█|  |  | ");
        Console.Beep(200, 100); Thread.Sleep(150); Console.SetCursorPosition(45, 5); Console.WriteLine("|█|█|█|   __|█|█|█|  |  | ");
        Console.Beep(150, 100); Thread.Sleep(150); Console.SetCursorPosition(45, 6); Console.WriteLine("|█|▀|█|_____|█|███|_____|");
        Thread.Sleep(150); Console.Beep(400, 100);

        //variables para la selección
        bool seleccion = true;
        int op = 0;
        ConsoleKeyInfo tecla;

        do //Bucle con las teclas W-S
        {
            //Condiciones para remarcar la opción a elegir
            if (op == 0)
            {
                Console.SetCursorPosition(54, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" JUGAR ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.SetCursorPosition(53, 10);
                Console.WriteLine(" JUGAR ");
            }
            if (op == 1)
            {
                Console.SetCursorPosition(54, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" REGLAS ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.SetCursorPosition(53, 11);
                Console.WriteLine(" REGLAS ");
            }
            if (op == 2)
            {
                Console.SetCursorPosition(54, 12);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" CANCHAS ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.SetCursorPosition(53, 12);
                Console.WriteLine(" CANCHAS ");
            }
            if (op == 3)
            {
                Console.SetCursorPosition(54, 13);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" SALIR ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.SetCursorPosition(53, 13);
                Console.WriteLine(" SALIR ");
            }

            //condiciones para analizar la tecla leída, y según eso asignar un valor a "op"
            tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.W)
            {
                if (op < 4)
                {
                    op--;
                    if (op < 0)
                        op = 3;
                }
            }
            else if (tecla.Key == ConsoleKey.S)
            {
                op++;
                if (op > 3)
                    op = 0;
            }
            else if (tecla.Key == ConsoleKey.Enter)
                seleccion = false;
            else
                op = 0;

        } while (seleccion);

        Console.Clear();
        return op;
    }

    //ALGORITMOS DENTRO DEL MENÚ
    static void reglas()
    {
        Console.Clear();
        Thread.Sleep(200); Console.SetCursorPosition(45, 3);
        Console.WriteLine("╦═╗╔═╗╔═╗╦  ╔═╗╔═╗");
        Thread.Sleep(150); Console.SetCursorPosition(45, 4);
        Console.WriteLine("╠╦╝║╣ ║ ╦║  ╠═╣╚═╗");
        Thread.Sleep(150); Console.SetCursorPosition(45, 5);
        Console.WriteLine("╩╚═╚═╝╚═╝╩═╝╩ ╩╚═╝");
        //rule4
        Thread.Sleep(300); Console.SetCursorPosition(20, 7);
        Console.WriteLine("Cómo jugar: "); Console.ForegroundColor = ConsoleColor.Gray;
        Thread.Sleep(300); Console.SetCursorPosition(25, 8);
        Console.WriteLine("- Conteste las tres preguntas para avanzar.");
        Thread.Sleep(300); Console.SetCursorPosition(25, 9);
        Console.WriteLine("- El primer equipo en marcar 3 goles ganará (en caso de empate continúa)");
        Thread.Sleep(300); Console.SetCursorPosition(25, 10);
        Console.WriteLine("- Conteste correctamente para tener más chance de marcar un gol.");
        Thread.Sleep(300); Console.SetCursorPosition(25, 11);
        Console.WriteLine("- Cada vez que falle una pregunta, tendrá menos chance de marcar un gol."); Console.ForegroundColor = ConsoleColor.White;
        //porcentajes
        Thread.Sleep(300); Console.SetCursorPosition(20, 13);
        Console.WriteLine("Porcentaje según sus respuestas"); Console.ForegroundColor = ConsoleColor.Gray;
        //--estadio 1
        Thread.Sleep(300); Console.SetCursorPosition(20, 14);
        Console.WriteLine("CANCHA NORMAL: ");
        Thread.Sleep(300); Console.SetCursorPosition(25, 15);
        Console.WriteLine("- 3 Aciertos     -> 90%");
        Thread.Sleep(300); Console.SetCursorPosition(25, 16);
        Console.WriteLine("- 2 Aciertos     -> 60%");
        Thread.Sleep(300); Console.SetCursorPosition(25, 17);
        Console.WriteLine("- 1 Acierto      -> 30%");
        Thread.Sleep(300); Console.SetCursorPosition(25, 18);
        Console.WriteLine("- 0 Aciertos     -> 10%");
        //--stadio 2
        Thread.Sleep(300); Console.SetCursorPosition(60, 14);
        Console.WriteLine("CANCHA FIRE_IN_THE_HOLE: ");
        Thread.Sleep(300); Console.SetCursorPosition(65, 15);
        Console.WriteLine("- 3 Aciertos     -> 60%");
        Thread.Sleep(300); Console.SetCursorPosition(65, 16);
        Console.WriteLine("- 2 Aciertos     -> 40%");
        Thread.Sleep(300); Console.SetCursorPosition(65, 17);
        Console.WriteLine("- 1 Acierto      -> 20%");
        Thread.Sleep(300); Console.SetCursorPosition(65, 18);
        Console.WriteLine("- 0 Aciertos     -> 0%");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Thread.Sleep(1000); Console.SetCursorPosition(15, 20); Console.WriteLine("(Presione cualquier tecla para salir)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
        Console.Clear();
    }
    static void MostrarEscenarios()
    {
        bool salir_menu = true;
        do
        {
            Console.Clear();
            int op = 0;
            bool salir = true;
            ConsoleKeyInfo tecla;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 3); Console.WriteLine("VISTA PREVIA CANCHAS");
                Console.SetCursorPosition(40, 5); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" OPCIONES: ");

                if (op == 0)
                {
                    Console.SetCursorPosition(46, 6); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" - Normal ");
                }
                else
                {
                    Console.SetCursorPosition(45, 6); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" - Normal ");
                }
                if (op == 1)
                {
                    Console.SetCursorPosition(46, 7); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" - Cancha difícil (muy díficil) ");
                }
                else
                {
                    Console.SetCursorPosition(45, 7); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" - Cancha difícil (muy díficil) ");
                }
                if (op == 2)
                {
                    Console.SetCursorPosition(46, 8); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" - Volver al menú ");
                }
                else
                {
                    Console.SetCursorPosition(45, 8); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" - Volver al menú ");
                }


                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.W)
                {
                    if (op < 3)
                    {
                        op--;
                        if (op < 0)
                            op = 2;
                    }
                }
                else if (tecla.Key == ConsoleKey.S)
                {
                    op++;
                    if (op > 2)
                        op = 0;
                }
                else if (tecla.Key == ConsoleKey.Enter)
                    salir = false;
                else
                    op = 0;

            } while (salir);

            switch (op)
            {
                case 0:
                    PosicionInicial();
                    Console.SetCursorPosition(70, 5); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Pulse cualquier tecla para volver");
                    Console.ReadKey();
                    break;
                case 1:
                    PosicionInicial2();
                    Console.SetCursorPosition(70, 5); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Pulse cualquier tecla para volver");
                    Console.ReadKey ();
                    break;
                case 2: salir_menu = false;break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }while(salir_menu);
    }
    static void salir_creditos()
    {
        Console.Clear();
        Thread.Sleep(150);
        string a1, a2, a3, a4, a5, borrador;
        string m1, m2, m3, m4, m5, m6, r1, r2, r3, r4, r5, r6, l1, l2, l3, l4, l5, l6;

        a1 = """   ____       __     _   _             """;
        a2 = """  / ___|_ __ /_/  __| (_)█|_ ___  ___  """;
        a3 = """ |█|   |█'__/ _ \/ _` |█|█__/ _ \/ __| """;
        a4 = """ |█|___|█| |  __/ (_| |█|█\| (_) \__ \ """;
        a5 = """  \____|█|  \___|\____|█|\__\___/|___/ """;
        borrador = "                                                                        ";
        l1 = """ _                        ___  ___           _                              """;
        l2 = """| |                       |  \/  |          | |                             """;
        l3 = """| |     ___   ___  _ __   | .  . | __ _ _ __| | ___  _ __                   """;
        l4 = """| |    / _ \ / _ \| '__|  | |\/| |/ _` | '__| |/ _ \| '_ \                  """;
        l5 = """| |___| (_) | (_) | |     | |  | | (_| | |  | | (_) | | | |                 """;
        l6 = """\_____/\___/ \___/|_|     \_|  |_/\__,_|_|  |_|\___/|_| |_|                 """;
        m1 = """ _    _               _                  _____  _                           """;
        m2 = """|  \/  |              | |                |  ___| (_)                        """;
        m3 = """| .  . | ___ _ __   __| | ___ ______ _   | |__ | |_  __ _ _ __              """;
        m4 = """| |\/| |/ _ \ '_ \ / _` |/ _ \_  / _` |  |  __|| | |/ _` | '_ \             """;
        m5 = """| |  | |  __/ | | | (_| | (_) / / (_| |  | |___| | | (_| | | | |            """;
        m6 = """\_|__|_/\___|_| |_|\__,_|\___/___\__,_|  \____/|_|_|\__,_|_| |_|            """;

        r1 = """ _____                               _____    _                     _       """;
        r2 = """| ___ \   (_)                       |  ___|  | |                   | |      """;
        r3 = """| |_/ /___ _ _ __   ___  ___  ___   | |__  __| |_   _  __ _ _ __ __| | ___  """;
        r4 = """|    // _ \ | '_ \ / _ \/ __|/ _ \  |  __|/ _` | | | |/ _` | '__/ _` |/ _ \ """;
        r5 = """| |\ \  __/ | | | | (_) \__ \ (_) | | |__| (_| | |_| | (_| | | | (_| | (_) |""";
        r6 = """\_| \_\___|_|_| |_|\___/|___/\___/  \____/\__,_|\__,_|\__,_|_|  \__,_|\___/ """;

        for (int i = 24; i > 1; i--)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(40, i);
            Console.WriteLine(a1);
            Console.SetCursorPosition(40, i + 1);
            Console.WriteLine(a2);
            Console.SetCursorPosition(40, i + 2);
            Console.WriteLine(a3);
            Console.SetCursorPosition(40, i + 3);
            Console.WriteLine(a4);
            Console.SetCursorPosition(40, i + 4);
            Console.WriteLine(a5);
            Console.SetCursorPosition(40, i + 5);
            Console.WriteLine(borrador);
            Console.ForegroundColor = ConsoleColor.White;
            if (i < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(30, i + 6);
                Console.WriteLine(l1);
                Console.SetCursorPosition(30, i + 7);
                Console.WriteLine(l2);
                Console.SetCursorPosition(30, i + 8);
                Console.WriteLine(l3);
                Console.SetCursorPosition(30, i + 9);
                Console.WriteLine(l4);
                Console.SetCursorPosition(30, i + 10);
                Console.WriteLine(l5);
                Console.SetCursorPosition(30, i + 11);
                Console.WriteLine(l6);
                Console.SetCursorPosition(30, i + 12);
                Console.WriteLine(borrador);
                Console.ForegroundColor = ConsoleColor.White;
                if (i < 11)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, i + 13);
                    Console.WriteLine(m1);
                    Console.SetCursorPosition(28, i + 14);
                    Console.WriteLine(m2);
                    Console.SetCursorPosition(28, i + 15);
                    Console.WriteLine(m3);
                    Console.SetCursorPosition(28, i + 16);
                    Console.WriteLine(m4);
                    Console.SetCursorPosition(28, i + 17);
                    Console.WriteLine(m5);
                    Console.SetCursorPosition(28, i + 18);
                    Console.WriteLine(m6);
                    Console.SetCursorPosition(28, i + 19);
                    Console.WriteLine(borrador);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (i < 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(23, i + 20);
                        Console.WriteLine(r1);
                        Console.SetCursorPosition(23, i + 21);
                        Console.WriteLine(r2);
                        Console.SetCursorPosition(23, i + 22);
                        Console.WriteLine(r3);
                        Console.SetCursorPosition(23, i + 23);
                        Console.WriteLine(r4);
                        Console.SetCursorPosition(23, i + 24);
                        Console.WriteLine(r5);
                        Console.SetCursorPosition(23, i + 25);
                        Console.WriteLine(r6);
                        Console.SetCursorPosition(23, i + 26);
                        Console.WriteLine(borrador);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            Console.Beep();
            Thread.Sleep(100);
        }
        Thread.Sleep(2000);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("""                                                               
                                                   ......''''''''''.....                                        
                                         ..',;:clooddxxxkkkkkkkkkkkkxxxddoolc:;,'..                             
                                   ..,:lodxkOkkkkxxxxxxddxxdxxxxxdxxxxxxxxxkkkkkkxdol:,..                       
                               ..';:lllccclloodxxxxxxxxxdxxxxxxxxxxxxxxxxxxxddollcccclllc;,'.                   
                               ............',;;:ccloddxxxxxxxxxxxxxxxddolcc::;,''..............                 
                          ...',;:cllloooodddddooooooddxxddxxxddddddddddoooooodddddoooolllc::;,'..               
                      .;cloddddddddddddddddddddddddddxxddddddddddddddddddddddddddddddddddxxddxddol:;'.          
                    'lkkxxddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddxxkdc'        
                  .cxkxxddddddddlc;,''....',,;codddddddddddddddddddddddddddol:;,''...'',;:lodddddddddxkkc.      
                 'okxddddddddo:',coddl,        .':oddddddddddddddddddddddl;';oddoc.       ..;lddddddddxxko'     
                'oxxddddddddo'  ;0NWWXd.          ,odddddddddddddddddddd:. .dXWWN0;          .cdddddddddxxo'    
               .cdddddddddddc.   .',,.            .cdddddddddddddddddddo,    .,,'.            ,ddddddddddddc.   
               ,odddddddddddo;.                  .:odddoddddddddddddddddc'                   'lddddodddddddo,   
               ;ooooooooooooool;'..          ..';loooooooooooooooooooooooo:,..           ..,cooooooooooooooo;   
               ,loooooooooooooooolc:;;,,,,;::clooooooooooooooooooooooooooooollc:;,,,,,;:cloooooooooooooooool,   
               .cllllllllccloollllllllooollllllllllllllllllllllllllllllllolllllllooooollllllllolccclollllll:.   
                ':cllllllc:;;;;:ccllllllllllllllllllllllllllllllllllllllllllllllllllllllllc:;;;;::cllllllc:'    
                 '::cccccccc:;,''''',,;;;::cccccccccccccccccccccccccccccccccccccc::;;,,''''',;:ccccccccc::'     
                  .,;::::::::::::;;,'...........'''''',,,,,,,,,,,,,,,,''''''..........'',;:::::::::::::;,.      
                   ..,;;:;;::::::;;::::;;;,,'''..............................'',,,;;::::;;::::;::;:;;;,..       
                     ..',,;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,'.          
                        ..',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,'..            
                           ...''',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,'''...               
                               ....''''''''''''''''''''''''''''''''''''''''''''''''''''''....                   
                                    ......''''''''''''''''''''''''''''''''''''''''......                        
                                          ..........''''''''''''''''''''..........                              
                                                      .................                                         
          
                                                      
                                                      
                                                      grasias x juegal


            """);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.DarkGray;

    }
    //Función para jugar
    static void Jugar ()
    {
        nombreequipo = (ingresar_nombre_equipo(ref nombreequipo));
        int cancha = SeleccionarCancha();
        switch (cancha)
        {
            case 0:
                JugarCancha1();
                break;
            case 1:
                JugarCancha2();
                break;
            case 2:
                break;         
        }
    }
    //Función para jugar en la cancha de nivel 1
    static void JugarCancha1()
    {
        bool sigajugando = true;
        int golLocal = 0, golVisita = 0;
        do
        {
            PosicionInicial();
            int resp = Preguntas();
            golLocal+=PenaltiCancha1(resp);
            PosicionInicial(); Console.SetCursorPosition(56, 2); Console.Write($"Turno del rival"); Thread.Sleep(800);
            golVisita += PenalAuto();
            CantidadGolesLocal(golLocal);
            CantidadGolesVisita(golVisita);
            if (golLocal >= 3 && golVisita < golLocal)
            {
                sigajugando = false;
                ganar_animacion();
            }
            else if (golVisita >= 3 && golLocal < golVisita)
            {
                sigajugando = false;
                perder_escena();
            }
        } while (sigajugando);

    }
    //Función para jugar en la cancha de nivel 20
    static void JugarCancha2()
    {
        bool sigajugando = true;
        int golLocal = 0, golVisita = 0;
        do
        {
            PosicionInicial2();
            int resp = Preguntas();
            golLocal += PenaltiCancha2(resp);
            PosicionInicial2(); Console.SetCursorPosition(56, 2); Console.Write($"Turno del rival"); Thread.Sleep(800);
            golVisita += PenalAuto2();
            CantidadGolesLocal(golLocal);
            CantidadGolesVisita(golVisita);
            if (golLocal >= 3 && golVisita < golLocal)
            {
                sigajugando = false;
                ganar_animacion();
            }
            else if (golVisita >= 3 && golLocal < golVisita)
            {
                sigajugando = false;
                perder_escena();
            }
        } while (sigajugando);
    }
    static int Preguntas ()
    {
        int respuestas = 0;
        respuestas = preguntanding();
        return respuestas;
    }
    //Seleccionar cancha previo al juego
    static int SeleccionarCancha ()
    {
        int opc=0;
        bool salir_menu = true;
        do
        {
            Console.Clear();
            bool salir = true;
            ConsoleKeyInfo tecla;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(40, 4); Console.WriteLine("SELECCIONE LA CANCHA PARA JUGAR");

                if (opc == 0)
                {
                    Console.SetCursorPosition(46, 6); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" - NORMAL ");
                }
                else
                {
                    Console.SetCursorPosition(45, 6); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" - NORMAL ");
                }
                if (opc == 1)
                {
                    Console.SetCursorPosition(46, 7); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" - DIFÍCIL ");
                }
                else
                {
                    Console.SetCursorPosition(45, 7); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" - DIFÍCIL ");
                }
                if (opc == 2)
                {
                    Console.SetCursorPosition(46, 8); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(" - Volver al menú ");
                }
                else
                {
                    Console.SetCursorPosition(45, 8); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" - Volver al menú ");
                }


                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.W)
                {
                    if (opc < 3)
                    {
                        opc--;
                        if (opc< 0)
                            opc = 2;
                    }
                }
                else if (tecla.Key == ConsoleKey.S)
                {
                    opc++;
                    if (opc > 2)
                        opc = 0;
                }
                else if (tecla.Key == ConsoleKey.Enter)
                    salir = false;
                else
                    opc= 0;

            } while (salir);
            switch (opc)
            {
                case 0:
                    salir_menu = false;
                    break;
                case 1:
                    salir_menu = false;
                    break;
                case 2: salir_menu = false;
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        } while (salir_menu);
        return opc;
       
    }
    //Penal ejecutado según la cantidad de respuestas correctas (Cancha1)
    static int PenaltiCancha1(int resp)
    {
        int Prob, goles = 0;
            PosicionInicial(); Console.SetCursorPosition(56, 2); Console.Write($"Turno de {nombreequipo}"); Thread.Sleep(1200);
        Prob = ProbabilidadGol1(resp);
            goles += RandomYResultado(Prob);
        return goles; 
    }
    //Penal ejecutado según la cantidad de respuestas correctas (Cancha2)
    static int PenaltiCancha2(int resp)
    {
        int Prob, goles=0;
        PosicionInicial2(); Console.SetCursorPosition(56, 2); Console.Write($"Turno de {nombreequipo}"); Thread.Sleep(1200);
        Prob = ProbabilidadGol2(resp);
        goles+= RandomYResultado2(Prob);
        return goles;
    }
    //Algoritmo que calcula las probabilidades de gol (Cancha1)
    static int ProbabilidadGol1(int resp)
    {
        int prob = 0;
        switch (resp)
        {
            case 0:
                prob = 1;
                break;
            case 1:
                prob = 3;
                break;
            case 2:
                prob = 6;
                break;
            case 3:
                prob = 9;
                break;
        }
        return prob;
    }
    //Algoritmo que calcula las probabilidades de gol (Cancha2)
    static int ProbabilidadGol2(int resp)
    {
        int prob = 0;
        switch (resp)
        {
            case 0:
                prob = 0;
                break;
            case 1:
                prob = 2;
                break;
            case 2:
                prob = 4;
                break;
            case 3:
                prob = 6;
                break;
        }
        return prob;
    }

    //Algoritmo que determina si es gol o no
    static int RandomYResultado(int prob) 
    {
        int gol = 0;
        Random random = new Random();
        if (prob < random.Next(1, 11))
            NoGol();
        else
        {
            Gol();
            gol=1;
        }
        return gol;
    }
    //Algoritmo que determina si es gol o no 2
    static int RandomYResultado2(int prob)
    {
        int gol = 0;
        Random random = new Random();
        if (prob < random.Next(1, 11))
            NoGol2();
        else
        {
            Gol2();
            gol = 1;
        }
        return gol;
    }
    //En caso de que sea gol
    static void Gol ()
    {
        AnimacionGol();
        gol_animacion();
    }
    //En caso de que sea gol 2
    static void Gol2()
    {
        AnimacionGol2();
        gol_animacion();
    }
    //En caso de que no sea gol
    static void NoGol()
    { 
        AnimacionNoGol();
        fallo_neutral_face();
    }
    //En caso de que no sea gol
    static void NoGol2()
    {
        AnimacionNoGol2();
        fallo_neutral_face();
    }
    //Animaciones en caso de que sea gol
    static void AnimacionGol()
    {
        Random tipodegol = new Random();
        switch (tipodegol.Next(0,3))
        {
            case 0:
                GolCentro();
                Thread.Sleep(200);
                break;
            case 1:
                GolDerecha();
                Thread.Sleep(200);
               break;
            case 2:
                GolIzq(); 
                Thread.Sleep(200);
                break;
        }
    }
    //Animaciones en caso de que sea gol 2
    static void AnimacionGol2()
    {
        Random tipodegol = new Random();
        switch (tipodegol.Next(0, 3))
        {
            case 0:
                GolCentro2();
                Thread.Sleep(200);
                break;
            case 1:
                GolDerecha2();
                Thread.Sleep(200);
                break;
            case 2:
                GolIzq2();
                Thread.Sleep(200);
                break;
        }
    }
    //Animaciones en caso de que no sea gol 
    static void AnimacionNoGol()
    {
        Random tiponogol = new Random();
        switch (tiponogol.Next(0, 2))
        {
            case 0:
                FalloDerecha();
                Thread.Sleep(200);
                break;
            case 1:
                FalloIzq();
                Thread.Sleep(200);
                break;
        }
    }
    //Animaciones en caso de que no sea gol 2
    static void AnimacionNoGol2()
    {
        Random tiponogol = new Random();
        switch (tiponogol.Next(0, 2))
        {
            case 0:
                FalloDerecha2();
                Thread.Sleep(200);
                break;
            case 1:
                FalloIzq2();
                Thread.Sleep(200);
                break;
        }
    }
    //Funcion para colocar el balón en el punto penal
    static void PosicionInicial()
    {
        Console.SetCursorPosition(0, 0);
        Console.Clear();
        Cancha(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
        Console.SetCursorPosition(25, 17);
        Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.White;
        Console.Write("■");
        Console.BackgroundColor = ConsoleColor.Black; Console.SetCursorPosition(0, 29); Thread.Sleep(200); Console.Write("Cargando");
        Thread.Sleep(500); Console.Write("."); Thread.Sleep(500); Console.Write("."); Thread.Sleep(500); Console.Write(".");
    }
    //Funcion para colocar el balón en el punto penal 2
    static void PosicionInicial2()
    {
        Console.SetCursorPosition(0, 0);
        Console.Clear();
        Cancha2(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
        Console.SetCursorPosition(25, 17);
        Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.BackgroundColor = ConsoleColor.White;
        Console.Write("■");
        Console.BackgroundColor = ConsoleColor.Black; Console.SetCursorPosition(0, 29); Console.Write("Cargando");
        Thread.Sleep(700); Console.Write("."); Thread.Sleep(600); Console.Write("."); Thread.Sleep(700); Console.Write(".");
    }
    //Animacion para gol al centro
    static void GolCentro()
    {
        Console.Clear();
        for (int i = 17; i < 28; i++)
        {
            Cancha(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para gol al centro 2
    static void GolCentro2()
    {
        Console.Clear();
        for (int i = 17; i < 28; i++)
        {
            Cancha2(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(25, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para gol al lado derecho
    static void GolDerecha()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j++)
        {
            Cancha(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25-j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para gol al lado derecho 2
    static void GolDerecha2()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j++)
        {
            Cancha2(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(25 - j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para gol al lado izquierdo
    static void GolIzq()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j++)
        {
            Cancha(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25 + j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para gol al lado izquierdo 2
    static void GolIzq2()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j++)
        {
            Cancha2(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(25 + j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para fallo al lado derecho
    static void FalloDerecha()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j += 2)
        {
            Cancha(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25 - j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para fallo al lado derecho 2
    static void FalloDerecha2()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j+=2)
        {
            Cancha2(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(25 - j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para fallo al lado izquierdo
    static void FalloIzq()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j+=2)
        {
            Cancha(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25 + j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Animacion para fallo al lado izquierdo 2
    static void FalloIzq2()
    {
        int j = 0;
        Console.Clear();
        for (int i = 17; i < 28; i++, j += 2)
        {
            Cancha2(marcoX1, marcoY1, marcoX2, marcoY2, nombreequipo);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(25 + j, i);
            Console.Write("■");
            Thread.Sleep(250);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    //Disparo de equipo auto (cancha1)
    static int PenalAuto()
    {
        int gol = 0;
        Random random = new Random();
        if (5 < random.Next(1, 11))
            NoGol();
        else
        {
            Gol();
            gol=1;
        }
        return gol;
    }
    //Disparo de equipo auto (cancha2)
    static int PenalAuto2()
    {
        int gol = 0;
        Random random = new Random();
        if (8 < random.Next(1, 11))
            NoGol2();
        else
        {
            Gol2();
            gol = 1;
        }
        return gol;
    }

    //Marcador que aparece en la parte superior
    static void Marcador(string equipo)
    {
        Console.SetCursorPosition(0,0);
        Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("███████████████████████████████████████████████████");
        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("███████████████████████████████████████████████████");
        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("███████████████████████████████████████████████████");
        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("███████████████████████████████████████████████████");
        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("███████████████████████████████████████████████████");
        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("███████████████████████████████████████████████████");
        Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("███████████████████████████████████████████████████");

        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue; Console.SetCursorPosition(4, 2); Console.Write(equipo.ToUpper());
        Console.SetCursorPosition(35, 2); Console.Write("EQUIPO RIVAL");
        Console.BackgroundColor = ConsoleColor.Black;
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(0, i); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("██");
            Console.SetCursorPosition(49, i); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("██");
        }
    }

    //Muestra la cantidad de goles marcados por su equipo
    static void CantidadGolesLocal (int golesLocal)
    {
        Marcador(nombreequipo);
        string c = "█";
        
        if (golesLocal>0)
        {
            for (int i = 4; golesLocal>0; i++, golesLocal--)
            {
                Console.SetCursorPosition(i, 4); Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(c);
            }
        }
    }
    //Muestra la cantidad de goles marcados por el bot
    static void CantidadGolesVisita(int golesVisita)
    {
        string c = "█";

        if (golesVisita > 0)
        {
            for (int i = 46; golesVisita>0; i--, golesVisita--)
            {
                Console.SetCursorPosition(i, 4); Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(c);
            }
        }
        Console.SetCursorPosition(0, 28); Console.Write("Pulse cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    //Animación mostrada después de marcar un gol
    static void gol_animacion()
    {
        int a = 1;
        Console.Clear();
        for (int i = 0; i < 5; i++)
        {
            color_txt_ran();
            Console.SetCursorPosition(10, 3 - a); Console.WriteLine("""                                                                                                    """);
            Console.SetCursorPosition(10, 4 - a); Console.WriteLine(""" .----------------.  .----------------.  .----------------.  .----------------.  .----------------. """);
            Console.SetCursorPosition(10, 5 - a); Console.WriteLine("""| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |""");
            Console.SetCursorPosition(10, 6 - a); Console.WriteLine("""| |    ______    | || |     ____     | || |     ____     | || |     ____     | || |     ____     | |""");
            Console.SetCursorPosition(10, 7 - a); Console.WriteLine("""| |  .' ___  |   | || |   .'    `.   | || |   .'    `.   | || |   .'    `.   | || |   .'    `.   | |""");
            Console.SetCursorPosition(10, 8 - a); Console.WriteLine("""| | / .'   \_|   | || |  /  .--.  \  | || |  /  .--.  \  | || |  /  .--.  \  | || |  /  .--.  \  | |""");
            Console.SetCursorPosition(10, 9 - a); Console.WriteLine("""| | | |    ____  | || |  | |    | |  | || |  | |    | |  | || |  | |    | |  | || |  | |    | |  | |""");
            Console.SetCursorPosition(10, 10 - a); Console.WriteLine("""| | \ `.___]  _| | || |  \  `--'  /  | || |  \  `--'  /  | || |  \  `--'  /  | || |  \  `--'  /  | |""");
            Console.SetCursorPosition(10, 11 - a); Console.WriteLine("""| |  `._____.'   | || |   `.____.'   | || |   `.____.'   | || |   `.____.'   | || |   `.____.'   | |""");
            Console.SetCursorPosition(10, 12 - a); Console.WriteLine("""| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |""");
            Console.SetCursorPosition(10, 13 - a); Console.WriteLine(""" '----------------'  '----------------'  '----------------'  '----------------'  '----------------' """);
            Console.SetCursorPosition(10, 14 - a); Console.WriteLine("""                                                                                                    """);
            Thread.Sleep(250);
            color_txt_ran();
            Console.SetCursorPosition(10, 14 + a); Console.WriteLine("""                                                                                                    """);
            Console.SetCursorPosition(10, 15 + a); Console.WriteLine(""" .----------------.  .----------------.  .----------------.  .----------------.  .----------------. """);
            Console.SetCursorPosition(10, 16 + a); Console.WriteLine("""| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |""");
            Console.SetCursorPosition(10, 17 + a); Console.WriteLine("""| |     ____     | || |     ____     | || |   _____      | || |   _____      | || |      -       | |""");
            Console.SetCursorPosition(10, 18 + a); Console.WriteLine("""| |   .'    `.   | || |   .'    `.   | || |  |_   _|     | || |  |_   _|     | || |     | |      | |""");
            Console.SetCursorPosition(10, 19 + a); Console.WriteLine("""| |  /  .--.  \  | || |  /  .--.  \  | || |    | |       | || |    | |       | || |     | |      | |""");
            Console.SetCursorPosition(10, 20 + a); Console.WriteLine("""| |  | |    | |  | || |  | |    | |  | || |    | |   _   | || |    | |   _   | || |     | |      | |""");
            Console.SetCursorPosition(10, 21 + a); Console.WriteLine("""| |  \  `--'  /  | || |  \  `--'  /  | || |   _| |__/ |  | || |   _| |__/ |  | || |     (_)      | |""");
            Console.SetCursorPosition(10, 22 + a); Console.WriteLine("""| |   `.____.'   | || |   `.____.'   | || |  |________|  | || |  |________|  | || |              | |""");
            Console.SetCursorPosition(10, 23 + a); Console.WriteLine("""| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |""");
            Console.SetCursorPosition(10, 24 + a); Console.WriteLine(""" '----------------'  '----------------'  '----------------'  '----------------'  '----------------' """);
            Console.SetCursorPosition(10, 25 + a); Console.WriteLine("""                                                                                                    """);

            Console.Beep(100, 200); Thread.Sleep(250);
            a++;
            if (a > 2)
                a = 1;
        }
        Thread.Sleep(300);
        Console.Clear();
    }
    //Animación mostrada después de errar un penal
    static void fallo_neutral_face()
    {
        Console.ForegroundColor= ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("""
                                   .,coxO0KKKKXKKKKKKOxo:'.                        
                                .;ok0KKKKXXXXXXXXNXXXXXXXKOdc'                     
                              .cx00KKKKKXXXXXNNNNNNNNNNNXXXXX0xc'                  
                            .cxO00KKKKKXXXXXNNNNNWWWWNNNNXXXXKKK0d,                
                           .:dkOO00KKKKKXXXXXXNNNNNWWWWNNXXXXXXKKKK0o.             
                         .lxkOOO00KKKKKKXXXXXXXNNNNWWWNNXXXXXKKKKK00k:.            
                        ,oxkkOOO000KKKKKKKXXXXXXNNNNWNNNXXXXKKKKKKK000o.           
                      .;dxkkOOOO0000KKKKKKKXXXXXXXNNNNNNXXXXKKKKKKK0000k:.         
                     .cdxkkkOOOOO000KKKKXXKKKKKKKKXXXXXXXXXXXKKKKKK00000Oo.        
                    .cdxxkkOOOOOO000000KKKKKKKKKKKKKKKKXKK00KKKKK00000000Oo.       
                   .cddxxkkkkkkOOOdc,'',cxKKKXXXXXXXKKOd:'..,cx00000000000Oo.      
                  .cddxxkkkkkkxxkx;. ...lO0K0Oxxkk0KXXKkc..   'x00000000000Oo.     
                 .:oddxxkkkkkxxxddo:;clx0Okd,......,dKXXKOo;,:okO000000000OOOo.    
                .;lodxxxkkkkkkxxxxxddxkO0OOo.      .lKKKKK0kxkkO0000000000OOOkl.   
                ;loodxxxxkkkkkkkkkOOOOOOOOOOd,    .cOKK0000KKKKK0000000000OOOOk:   
               'cooddxxxxkkkkkkkkkOOOOkxxxxxo;.   .;okOOOOk00000OOOOO00000OOOOkd'  
              .:lodddxxxxxkkxxxxxkkkOOkoll:'.      ..;ldxddkOOOOOOOOOOO000OOOOkkc. 
              ;loodddxxxxxxxxxxxxxxkkkkdlc::;,'....',,;:cloxxxkkOOOOOOOOOOOOOOkkd' 
              :loodddxxxxxxxxxxxxxxxxxxxxddoollcccclllooodxxxkkOOOOOOOOOOOOOOOkkk: 
             .cloddddxxxxxxxxxxxxxxxxxxxxxxxxddddddddxxkkkkkkOOOOOOOOOOOOOOOOOkkkl.
             ,looodddxxxxxxxxxxxxkkkkkkxxxxkkkkxxxxxkkkkkOOOOOOOOOOOOOOOOOOOOOkkkd,
             ;looddddxxxxxxxxxxxkkkkkkkkkkkkkxxxxxxxkkkkkkkkkOOOOOOOOOOOOOOOOkkkxx 
             ;lloddddxxxxxxxxxxxkkkkkkkkkkkkkxxxxxxxxxkkkkkkkkOOOOOOOOOOOOOOkkkxxx 
             ;lloodddxxxxxxxxxxxxkkkkkkkkkkkkkkxxxxxxxxxkkkkkkkkOOOOOOOOOOOkkkxxxd 
             ,clooddddxxxxxxxxxxkkkkkkkkkkkkkkxxxxxxxxxxkkkkkkkkkkkkkkkkkkkkkxxxxd 
             'cloodddddxxxxxxxxxkkkkkkkkkkkkkkxxxxxxxxxxxkkkkkkkkkkkkkkkkkkkxxxxdd 
            .:looddddddxxxxxxxxkkkkkkkkkkkkkkxxxxxxxxxxxxxkkkkkkkkkkkkkkkkxxxxddoc 
             'looodddddxxxxxxxxxkkkkkkkkkkkkkxxxxxxxxxxxxxxxxxkkkkkxxxxxxxxxddddo; 
             .cooooddddxxxxxxxxxxkkkkkkkkkkkxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdddddoc  
         """);
        Thread.Sleep(500);
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(75 + (i * 10), 10);
            Console.WriteLine(" ___ ");
            Console.SetCursorPosition(75 + (i * 10), 11);
            Console.WriteLine("|   |");
            Console.SetCursorPosition(75 + (i * 10), 12);
            Console.WriteLine("|___|");
            Console.Beep();
            Thread.Sleep(300);
        }
        Thread.Sleep(500);
        Console.Clear();
    }
    //Animación mostrada después de ganar la partida
    static void ganar_animacion()
    {
        Console.Clear();
        Console.WriteLine("""

             __   __ _____  _   _        
             \ \ / /|  _  || | | |       
              \ V / | | | || | | |       
               \ /  | | | || | | |       
               | |  \ \_/ /| |_| |       
               \_/   \___/  \___/        

              _    _  _____  _   _  _  _ 
             | |  | ||_   _|| \ | || || |
             | |  | |  | |  |  \| || || |
             | |/\| |  | |  | . ` || || |
             \  /\  / _| |_ | |\  ||_||_|
              \/  \/  \___/ \_| \_/(_)(_)                       
         """);
        bool salir = true;
        int a = 0, b = 45, cont = 0;
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(b, 2 + a); Console.WriteLine("""                                                   """);
            Console.SetCursorPosition(b, 3 + a); Console.WriteLine("""                  .;lxl.  ,xdc'                   """);
            Console.SetCursorPosition(b, 4 + a); Console.WriteLine("""                .oKWMMO.  cWMMNk:.                """);
            Console.SetCursorPosition(b, 5 + a); Console.WriteLine("""               ;KMMMNO:   .dKWMMWx.               """);
            Console.SetCursorPosition(b, 6 + a); Console.WriteLine("""               .;ldl, .,:;. .:ooc,.               """);
            Console.SetCursorPosition(b, 7 + a); Console.WriteLine("""             .:l;.  .c0WMWXk,  .,:l'              """);
            Console.SetCursorPosition(b, 8 + a); Console.WriteLine("""             .kMWXc .xWMMMMX: .kWMWc              """);
            Console.SetCursorPosition(b, 9 + a); Console.WriteLine("""              lWMMK, 'dkkkkc  oWMM0'              """);
            Console.SetCursorPosition(b, 10 + a); Console.WriteLine("""              .xWMK;  .....  .dNMX:               """);
            Console.SetCursorPosition(b, 11 + a); Console.WriteLine("""               .co' .dO0000k:  :d,                """);
            Console.SetCursorPosition(b, 12 + a); Console.WriteLine("""                   .dXWWWWWN0;                    """);
            Console.SetCursorPosition(b, 13 + a); Console.WriteLine("""                   ...',;;,'..                    """);
            Console.SetCursorPosition(b, 14 + a); Console.WriteLine("""                  'xxolccccldkl                   """);
            Console.SetCursorPosition(b, 15 + a); Console.WriteLine("""                  .OMMMMMMMMMWl                   """);
            Console.SetCursorPosition(b, 16 + a); Console.WriteLine("""                   dMMMMMMMMMX;                   """);
            Console.SetCursorPosition(b, 17 + a); Console.WriteLine("""                   :NMMMMMMMMO.                   """);
            Console.SetCursorPosition(b, 18 + a); Console.WriteLine("""                 ..:KMMMMMMMMx'..                 """);
            Console.SetCursorPosition(b, 19 + a); Console.WriteLine("""                ;0XXWMMMMMMMMNXXd.                """);
            Console.SetCursorPosition(b, 20 + a); Console.WriteLine("""                :NMMMMMMMMMMMMMMk.                """);
            Console.SetCursorPosition(b, 21 + a); Console.WriteLine("""                .loooooooooooooo;                 """);
            Console.SetCursorPosition(b, 22 + a); Console.WriteLine("""            .........................             """);
            Console.SetCursorPosition(b, 23 + a); Console.WriteLine("""            oNNNNNNNNNNNNNNNNNNNNNNN0,            """);
            Console.SetCursorPosition(b, 24 + a); Console.WriteLine("""            dMMMMMMMMMMMMMMMMMMMMMMMX;            """);
            Console.SetCursorPosition(b, 25 + a); Console.WriteLine("""            ,lllllllllllllllllllllllc.            """);
            Console.SetCursorPosition(b, 26 + a); Console.WriteLine("""                                                   """);
            if (a < 1) a++;
            else a--;
            cont++;
            if (cont > 9)
            {
                Console.Beep(200, 200); Console.Beep(200, 200);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("(Presione cualquier tecla para continuar)");
                if (Console.KeyAvailable)
                    salir = false;
            }
            Thread.Sleep(500);
        } while (salir);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
    }
    //Animación mostrada después de perder la partida
    static void perder_escena()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 4); Console.WriteLine("""                                                   """);
        Console.SetCursorPosition(40, 5); Console.WriteLine("""            ████████████""");
        Console.SetCursorPosition(40, 6); Console.WriteLine("""        ███████▒▒▒▒▒▒▒▒▒███""");
        Console.SetCursorPosition(40, 7); Console.WriteLine("""     █████████▒▒▒▒▒▒▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 8); Console.WriteLine("""    ██▒███▒▒▒▒██▒▒▒▒▒▒▒▒▒█▒▒▒██""");
        Console.SetCursorPosition(40, 9); Console.WriteLine("""   █▒▒▒█▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒█▒▒▒▒▒▒██""");
        Console.SetCursorPosition(40, 10); Console.WriteLine("""  █▒▒▒█▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒▒██""");
        Console.SetCursorPosition(40, 11); Console.WriteLine(""" █▒▒▒██▒▒▒▒▒▒▒▒▒█████████▒▒▒▒▒▒▒▒█""");
        Console.SetCursorPosition(40, 12); Console.WriteLine("""██▒▒▒█▒▒▒▒▒▒▒▒▒▒██████████▒▒▒▒▒▒▒▒█""");
        Console.SetCursorPosition(40, 13); Console.WriteLine("""█▒▒▒██▒▒▒▒▒▒▒▒████████████▒▒▒▒▒▒▒▒█""");
        Console.SetCursorPosition(40, 14); Console.WriteLine("""█▒▒█████▒▒▒███▒▒▒███████▒▒████▒▒▒██""");
        Console.SetCursorPosition(40, 15); Console.WriteLine("""███████████▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒█████""");
        Console.SetCursorPosition(40, 16); Console.WriteLine("""█▒███████▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 17); Console.WriteLine("""█▒███████▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 18); Console.WriteLine(""" █▒██████▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒███""");
        Console.SetCursorPosition(40, 19); Console.WriteLine("""  █▒██▒▒██▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒██▒██""");
        Console.SetCursorPosition(40, 20); Console.WriteLine("""   ██▒▒▒▒▒███▒▒▒▒█████▒▒▒▒███▒▒▒█""");
        Console.SetCursorPosition(40, 21); Console.WriteLine("""    ██▒▒▒▒▒▒███████████████▒▒▒██""");
        Console.SetCursorPosition(40, 22); Console.WriteLine("""     ███▒▒▒▒▒▒██████████▒▒▒▒██""");
        Console.SetCursorPosition(40, 23); Console.WriteLine("""       ████▒▒▒█████████▒▒███""");
        Console.SetCursorPosition(40, 24); Console.WriteLine("""          █████▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 25); Console.WriteLine("""                                                   """);
        Thread.Sleep(2000);
        Console.SetCursorPosition(40, 4); Console.WriteLine("""                                                   """);
        Console.SetCursorPosition(40, 5); Console.WriteLine("""            ████    ████""");
        Console.SetCursorPosition(40, 6); Console.WriteLine("""        ███████▒▒▒▒▒▒▒▒▒███""");
        Console.SetCursorPosition(40, 7); Console.WriteLine("""            ███▒▒▒▒▒▒▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 8); Console.WriteLine("""    ██▒█▒▒▒▒█   ▒▒▒▒▒▒▒█▒▒▒██""");
        Console.SetCursorPosition(40, 9); Console.WriteLine("""   █▒▒     ▒▒▒▒▒▒█▒▒▒▒▒▒▒█▒▒▒▒▒▒██""");
        Console.SetCursorPosition(40, 10); Console.WriteLine("""  █▒▒▒█▒▒▒    ▒▒▒▒████████▒▒▒▒▒▒▒██""");
        Console.SetCursorPosition(40, 11); Console.WriteLine(""" █▒▒▒██▒▒▒▒▒▒▒   ████████▒▒▒▒▒▒▒▒█""");
        Console.SetCursorPosition(40, 12); Console.WriteLine("""██▒▒▒█▒▒▒▒▒▒▒▒▒▒██████████▒        """);
        Console.SetCursorPosition(40, 13); Console.WriteLine("""█▒▒▒██▒▒▒▒▒▒▒▒██████     ▒▒▒▒▒▒▒▒█""");
        Console.SetCursorPosition(40, 14); Console.WriteLine("""█▒▒█████▒▒▒█       ██████▒▒████▒▒▒██""");
        Console.SetCursorPosition(40, 15); Console.WriteLine("""██████    █▒▒▒▒▒▒▒▒ █▒▒▒▒▒▒▒▒█████""");
        Console.SetCursorPosition(40, 16); Console.WriteLine("""█▒███ ███▒▒▒▒▒▒▒▒▒▒▒█ ▒▒▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 17); Console.WriteLine("""█      ███▒▒▒▒▒▒▒▒▒▒▒█▒ ▒▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 18); Console.WriteLine("""   ██████▒▒▒     ▒▒▒▒██▒▒▒▒  ▒▒▒▒███""");
        Console.SetCursorPosition(40, 19); Console.WriteLine("""  █▒██▒▒██    ▒▒▒▒▒▒█▒▒▒▒▒▒▒  ██▒██""");
        Console.SetCursorPosition(40, 20); Console.WriteLine("""   ██▒▒▒     █▒▒▒▒█████▒▒▒▒███  ▒█""");
        Console.SetCursorPosition(40, 21); Console.WriteLine("""    ██▒▒    █████     ████▒▒▒██""");
        Console.SetCursorPosition(40, 22); Console.WriteLine("""     ███▒▒▒▒▒▒██         █▒▒▒▒██""");
        Console.SetCursorPosition(40, 23); Console.WriteLine("""          █▒▒▒████    █▒▒███""");
        Console.SetCursorPosition(40, 24); Console.WriteLine("""          █████▒▒▒▒▒▒████""");
        Console.SetCursorPosition(40, 25); Console.WriteLine("""                                                   """);
        Console.Beep(100, 400); Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("""
                     
          ▄▀▀▄ ▀▀▄  ▄▀▀▀▀▄   ▄▀▀▄ ▄▀▀▄      ▄▀▀▀▀▄      ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀█▄▄▄▄ 
         █   ▀▄ ▄▀ █      █ █   █    █     █    █      █      █ █ █   ▐ ▐  ▄▀   ▐ 
         ▐     █   █      █ ▐  █    █      ▐    █      █      █    ▀▄     █▄▄▄▄▄  
               █   ▀▄    ▄▀   █    █           █       ▀▄    ▄▀ ▀▄   █    █    ▌  
             ▄▀      ▀▀▀▀      ▀▄▄▄▄▀        ▄▀▄▄▄▄▄▄▀   ▀▀▀▀    █▀▀▀    ▄▀▄▄▄▄   
             █                               █                   ▐       █    ▐   
             ▐                               ▐                           ▐        
         

         """);
        Console.Beep(100, 200);
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("(Presione cualquier tecla para continuar)");
        Console.ReadKey();
        Console.Clear();
    }
    //Función para ingresar el nombre del equipo
    static string ingresar_nombre_equipo(ref string nombre)
    {
        //mostrar letras grandes
        Console.Beep(1000, 150);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("""
                                   _             
                                  | |                  
             _ __   ___  _ __ ___ | |__  _ __ ___      
            | '_ \ / _ \| '_ ` _ \| '_ \| '__/ _ \          
            | | | | (_) | | | | | | |_) | | |  __/             
            |_| |_|\___/|_| |_| |_|_.__/|_|  \___|               
            """);
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("""
                | |                                                      
              __| | ___    ___ _   _                                              
             / _` |/ _ \  / __| | | |                                          
            | (_| |  __/  \__ | |_| |                                   
             \__,_|\___|  |___/___,_|                            
                             (_)             |__ \            
            """);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("""
              ___  __ _ _   _ _ _ __   ___      ) |      
             / _ \/ _` | | | | | '_ \ / _ \    / /     
            |  __| (_| | |_| | | |_) | (_) |  |_|   
             \___|\__, |\__,_|_| .__/ \___/   (_) 
                     | |       | |             
                     |_|       |_|         
                                  
            """);
        //volver colores a la normalidad
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("");
        //pedir el nombre del equipo
        Console.Write("Mi equipo se llama: "); Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.Red;
        string equipo_nombre = Convert.ToString(Console.ReadLine());
        if (equipo_nombre.Length > 12)
            equipo_nombre = equipo_nombre.Substring(0, 10);
        equipo_nombre = equipo_nombre.ToUpper();
        Console.ForegroundColor = ConsoleColor.White; Console.CursorVisible = false;
        Console.Clear();
        nombre = equipo_nombre;
        return equipo_nombre;
    }
   

    //Cancha dibujada con marcador incluido
    static void Cancha(int x1, int y1, int x2, int y2, string nombreequipo)
    {
        Marcador(nombreequipo);
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;
        for (int f = y1; f <= y2; f++)
        {
            Console.SetCursorPosition(x1, f); Console.Write("█"); //Va desde x1 que esta en 0 hacia abajo en y2 que en este caso vale f y va incremetnado hasta llegar al y2
            Console.SetCursorPosition(x2, f); Console.Write("█"); //Asi igual este
        }
        for (int c = x1; c <= x2; c++)
        {
            Console.SetCursorPosition(c, y1); Console.Write("▄"); //Como estan las lineas verticales faltaban las verticales
            Console.SetCursorPosition(c, y2); Console.Write("▀");

        }
        Console.BackgroundColor = ConsoleColor.Green;
        for (int f = y1 + 1; f < y2; f++)
        {
            for (int c = x1 + 1; c < x2; c++)
            {
                Console.SetCursorPosition(c, f);
                Console.Write(" ");
            }
        }
        // Aqui la raya que va un poco mas atras de la linea del campo , le sumamos y1 + y2 para que nos de la mitad de los ejes de las y
        int MitadY = (y1 + y2) / 2;
        for (int a = x1 + 1; a < x2; a++)
        {
            Console.SetCursorPosition(a, MitadY - 4); //Se puede cambia el -4 , si lo quieres mas atras otro numero menos , o mas adelante debes de sumarle
            Console.Write("═");
        }
        //Aqui estara la dimension de donde a donde del arco
        int arcoY = y2 - 1; // Para que mo tope con el marco de abajo se le resta uno xd
        for (int c = x1 + 13; c < x2 - 13; c++) // x1 le sumamos para que el arco no empiece desde o si no un poco mas adelante como deberia ser y sea peuqeño y a x2 le restamos ya que es la dimension mas grande y es la que esta a la derecha, y restamos para que vaya un poco a la izquierda y ahi es donde termina el arco
        {
            Console.SetCursorPosition(c, arcoY); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▄▄");
        }
        //Aqui el circulo del penal
        Console.ForegroundColor = ConsoleColor.White;
        int OtramitadArco = (MitadY + MitadY) / 2;
        Console.SetCursorPosition(24, OtramitadArco);// El 24 sera el eje de la x en posicion 24 que sera para adelante y el otro va para abajop
        Console.Write("███");

        // El area donde cubre el arco 
        int areaPenalY = y2 - 4; //Se resta el -4 al y2 ya que asi empieza la linea haciua abajo que cubre el area un poco mas abajo del punto penal, si restamos un numero mas grande se va mas atras
        int areaPenalX1 = MitadY - 4; //Aqui iniciara o estara el primer lado del arco
        int areaPenalX2 = MitadY + 20; //Aqui iniciara o estara el segundo lado del arco

        for (int f = areaPenalY; f <= y2 - 1; f++)
        {
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.SetCursorPosition(areaPenalX1, f); Console.Write("█");
            Console.SetCursorPosition(areaPenalX2, f); Console.Write("█");
        }
        for (int c = areaPenalX1; c <= areaPenalX2; c++)
        {
            Console.SetCursorPosition(c, areaPenalY); Console.Write("▄");
        }
      
    }
    //Cancha 2 dibujada con marcador incluido
    static void Cancha2(int x1, int y1, int x2, int y2, string nombreequipo)
    {
        Marcador(nombreequipo);
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.White;
        for (int f = y1; f <= y2; f++)
        {
            Console.SetCursorPosition(x1, f); Console.Write("█"); //Va desde x1 que esta en 0 hacia abajo en y2 que en este caso vale f y va incremetnado hasta llegar al y2
            Console.SetCursorPosition(x2, f); Console.Write("█"); //Asi igual este
        }
        for (int c = x1; c <= x2; c++)
        {
            Console.SetCursorPosition(c, y1); Console.Write("▄"); //Como estan las lineas verticales faltaban las verticales
            Console.SetCursorPosition(c, y2); Console.Write("▀");

        }
        Console.BackgroundColor = ConsoleColor.Cyan;
        for (int f = y1 + 1; f < y2; f++)
        {
            for (int c = x1 + 1; c < x2; c++)
            {
                Console.SetCursorPosition(c, f);
                Console.Write(" ");
            }
        }
        // Aqui la raya que va un poco mas atras de la linea del campo , le sumamos y1 + y2 para que nos de la mitad de los ejes de las y
        int MitadY = (y1 + y2) / 2;
        for (int a = x1 + 1; a < x2; a++)
        {
            Console.SetCursorPosition(a, MitadY - 4); //Se puede cambia el -4 , si lo quieres mas atras otro numero menos , o mas adelante debes de sumarle
            Console.Write("═");
        }
        //Aqui estara la dimension de donde a donde del arco
        int arcoY = y2 - 1; // Para que mo tope con el marco de abajo se le resta uno xd
        for (int c = x1 + 13; c < x2 - 13; c++) // x1 le sumamos para que el arco no empiece desde o si no un poco mas adelante como deberia ser y sea peuqeño y a x2 le restamos ya que es la dimension mas grande y es la que esta a la derecha, y restamos para que vaya un poco a la izquierda y ahi es donde termina el arco
        {
            Console.SetCursorPosition(c, arcoY); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▄▄");
        }
        //Aqui el circulo del penal
        Console.ForegroundColor = ConsoleColor.White;
        int OtramitadArco = (MitadY + MitadY) / 2;
        Console.SetCursorPosition(24, OtramitadArco);// El 24 sera el eje de la x en posicion 24 que sera para adelante y el otro va para abajop
        Console.Write("███");

        // El area donde cubre el arco 
        int areaPenalY = y2 - 4; //Se resta el -4 al y2 ya que asi empieza la linea haciua abajo que cubre el area un poco mas abajo del punto penal, si restamos un numero mas grande se va mas atras
        int areaPenalX1 = MitadY - 4; //Aqui iniciara o estara el primer lado del arco
        int areaPenalX2 = MitadY + 20; //Aqui iniciara o estara el segundo lado del arco

        for (int f = areaPenalY; f <= y2 - 1; f++)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(areaPenalX1, f); Console.Write("█");
            Console.SetCursorPosition(areaPenalX2, f); Console.Write("█");
        }
        for (int c = areaPenalX1; c <= areaPenalX2; c++)
        {
            Console.SetCursorPosition(c, areaPenalY); Console.Write("▄");
        }

    }

    static void color_txt_ran()
    {
        //saca un color random
        int r = valor_random();
        switch (r)
        {
            case 0: Console.ForegroundColor = ConsoleColor.Gray; break;
            case 1: Console.ForegroundColor = ConsoleColor.Green; break;
            case 2: Console.ForegroundColor = ConsoleColor.Red; break;
            case 3: Console.ForegroundColor = ConsoleColor.Blue; break;
            case 4: Console.ForegroundColor = ConsoleColor.White; break;
            case 5: Console.ForegroundColor = ConsoleColor.Yellow; break;
            case 6: Console.ForegroundColor = ConsoleColor.Cyan; break;
            case 7: Console.ForegroundColor = ConsoleColor.Magenta; break;
        }
    }
    static int valor_random()
    {
        Random random = new Random();
        return random.Next(0, 8);
    }

     static int preguntanding()
    {
        int RespuestasCorrectas = 0, espacio = 0;
        int ronda = 0;
       
        while (ronda < 1)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(56, 1+espacio); Console.WriteLine("Tanda de Penales");
            RespuestasCorrectas+= Preguntas(ref espacio);
            ronda++;
        }
        Console.SetCursorPosition(0, 29); Console.Write("             Pulse espacio para empezar     ");
        while (Console.ReadKey().Key != ConsoleKey.Spacebar)
        {
        }
        return RespuestasCorrectas;
    }
     static int Preguntas( ref int espacio)
    {
        int respuestascorrectas = 0;
        Console.SetCursorPosition(56, 2+espacio); Console.Write("Preguntas (ingrese la letra del literal correspondiente)");
        string[,] preguntas = {
            {"¿Cuál es el deporte más popular en el mundo?",  "a) Fútbol", "b) Basketball", "c) Tenis", "a"}, //0
            {"¿Cuál es la capital de Francia?", "a) Madrid", "b) París", "c) Londres", "b"}, //1
            {"¿Cuál es el jugador conocido como 'La Pulga' ? ", "a) Messi", "b) Maradona", "c) Cristiano", "a" }, //2
            {"¿Cuál es el simbolo quimico del agua?" , "a) Ar", "b) H2o ", "c) Fe", "b"}, //3
            {"¿Cuál es el océano más grande del mundo?", "a) Océano Atlántico", "b) Océano Índico", "c) Océano Pacífico", "c"}, //4
            {"¿Cuál es el país que ha ganado más Copas Mundiales de la FIFA?" , "a) Argentina" , "b) Brasil" , "c) Alemania" , "b"}, //5
            {"¿Cuál es la montaña más alta del mundo?", "a) Monte Everest", "b) Monte Kilimanjaro", "c) Monte Aconcagua", "a"}, //6
            {"¿Cuál es el planeta más grande del sistema solar?" , "a) Tierra", "b) Júpiter" , "c) Neptuno" , "b"} , //7
            {"¿Quién es el máximo goleador en la historia de la Champions?" , "a) Messi" , "b) Cristiano", "c) Ronaldinho " , "b"}, //8
            {"¿Cuál es el valor de π (pi) aproximadamente? " , "a) 3.1416" , "b) 2.14" , "c) 2.71" , "a" }, //9
            {"¿¿Cuál es la suma de los ángulos internos de un triángulo?" , "a) 0" , "b) 360" , "c) 180" , "c" }, //10
            {"¿Cuál es el resultado de 3^2 + 4^2?" , "a) 9" , "b) 25" , "c) 10" ,"b"}, //11
            {"¿Qué selección ganó la primera Copa Mundial de la FIFA?" , "a) Brasil" , "b) Italia" , "c) Uruguay" , "c"}, //12
            {"¿Cuánto es la raíz cuadrada de 144?" , "a) 12" , "b) 13" , "c) 15" , "a"}, //13
            {"¿Cuál es el río más largo del mundo?" ,"a) Nilo" , "b) Yangtsé" , "c) Amazonas" , "c" }, //14
            {"¿Cuál es la capital de España?", "a) Madrid" ,"b) Barcelona","c) Sevilla","a" },//15
            {"¿En qué país se encuentra la Gran Barrera de Coral?","a) México","b) Australia","c) Perú", "b" },//16
            {"¿Quién ganó la Copa del Mundo en 2022?", "a) Brasil","b) Argentina","c) Francia","b"},//17
            {"¿Cuál es el país más grande del mundo en términos de territorio?","a) China","b) Estados Unidos","c) Rusia","c"},//18
            {"¿En qué continente se encuentra el desierto del Sahara?","a) América","b) Asia","c) África","c"},//19
            {"¿Quién es el máximo ganador del Balón de Oro?","a) Lionel Messi","b) Cristiano Ronaldo","c) Michel Platini","a" },//20
            {"¿Quién es el máximo goleador histórico de Brasil?", "a) Pelé","b) Romário","c) Neymar Jr.","a" },//21
            {"¿Cuál es la capital de Japón?","a) Seúl","b) Pekín","c) Tokio","c" },//22
            {"¿En qué país se encuentra la Patagonia?","a) Chile","b) Noruega","c) Argentina","c" },//23
            {"¿Cuál es el país más pequeño del mundo (territorialmente)?","a) Ecuador","b) Mónaco","c) El Vaticano","c" },//24
            {"¿En qué país se encuentra la Torre Eiffel?","a) Italia","b) España","c) Francia","c"},//25
            {"¿Cuál es el la ciudad más poblada del mundo?","a) París","b) Nueva York","c) Tokio","c"}//26
        };

        Random npregunta = new Random();
        int compararanterior = 0;
        int primerapregunta = 0;

        for (int j=0; j<3;  j++)
        {
            int i = npregunta.Next(0, 27); //seleccionar una pregunta aleatoria
            if (i == compararanterior ) //comparar si la pregunta es igual a la mostrada anteriormente
            {
                if (i == 26)
                {
                    i--;
                }
                else
                {
                    i++;
                }
            }
           
            if (j==2) //compara la última pregunta con la primera
            {
                if (primerapregunta==i)
                {
                    if (i == 26) //evalúa si es la última pregunta
                    {
                        i--;
                        if (i == compararanterior) // compara con la pregunta anterior
                            i--;
                    }
                    else
                    {
                        i++;
                        if (i == compararanterior) // compara con la pregunta anterior
                        {
                            if (i == 26) //evalúa si es la última pregunta
                            {
                                i = 0;
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                }
            }
            string pregunta = preguntas[i, 0];
            string literalA = preguntas[i, 1];
            string literalB = preguntas[i, 2];
            string literalC = preguntas[i, 3];
            string respuesta = preguntas[i, 4];
            respuestascorrectas += mostrarPreguntas(pregunta, literalA, literalB, literalC, respuesta, ref espacio);
            compararanterior = i;
            if (j == 0) //asigna numero de la primera pregunta
            {
                primerapregunta = i;
            }
        }
        return respuestascorrectas;
    }

     static int mostrarPreguntas(string pregunta, string literalA, string literalB, string literalC, string respuesta, ref int espacio)
    {
        int cantidadRespuestas = 0;
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(56, 3+espacio); Console.Write(pregunta);
        Console.SetCursorPosition(56, 4+espacio); Console.Write(literalA);
        Console.SetCursorPosition(56, 5+espacio); Console.Write(literalB);
        Console.SetCursorPosition(56, 6+espacio); Console.Write(literalC);
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.SetCursorPosition(56, 7+espacio); Console.Write("Ingrese su respuesta: ");
        Console.CursorVisible = true;
        string respuestaUsuario = Console.ReadLine();
        Console.CursorVisible = false;


        if (respuestaUsuario.ToLower() == respuesta.ToLower())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(56, 9+espacio); Console.WriteLine("Respuesta correcta!");
            Console.ForegroundColor= ConsoleColor.White;
            cantidadRespuestas++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(56, 9+espacio); Console.WriteLine("Respuesta incorrecta.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        espacio +=8;
        return cantidadRespuestas; 
     }
}