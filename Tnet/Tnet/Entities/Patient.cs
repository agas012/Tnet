using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Collections.Specialized.BitVector32;
using System.Diagnostics;

namespace Tnet.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public int numcuestionario { get; set; }
        public int fechadeaplicacionDia { get; set; }
        public int fechadeaplicacionMes { get; set; }
        public int fechadeaplicacionAnio { get; set; }
        [Required]
        public required string Name { get; set; } //o paginap
        [Required]
        public required string? SurnameP { get; set; }//paginap 
        [Required]
        public required string? SurnameM { get; set; }//paginap
        [Required]
        public required string NameEnc { get; set; } //o paginap


        public string? ECUNumber { get; set; }//o paginap


        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }

        public string? Email1 { get; set; }
        public string? Email2 { get; set; }

        public int fechadenacimientoDia { get; set; }
        public int fechadenacimientoMes { get; set; }
        public int fechadenacimientoAnio { get; set; }

        public string? generoSeleccionado { get; set; }
        public List<string> Generos = new List<string> { "Hombre", "Mujer", "No binario", "Otro", "Prefiero no decirlo" };
        public string? generoOtro { get; set; } //nuevo

        public string? estadocivilSeleccionado { get; set; }
        public List<string> EstadosCiviles = new List<string> { "Soltera(o)", "Unión libre", "Casada(o)", "Separada(o)", "Divorciada(o)", "Viuda(o)" };

        public int aniosdeestudio { get; set; }

        public string? religionSeleccionada { get; set; }
        public List<string> Religiones = new List<string> { "Católica", "Protestante", "Otra" };
        public string? religionOtra { get; set; } //nuevo

        public bool HablalenguaIndigena { get; set; }
        public string? lenguaIndigenaCual { get; set; } //nuevo

        public bool PertenecegrupoEtnico { get; set; }
        public string? grupoEtnicoCual { get; set; } //nuevo

        public string? ocupacionSeleccionada { get; set; }
        public List<string> Ocupaciones = new List<string> {
            "Funcionarios, directores y jefes",
            "Profesionistas y técnicos",
            "Trabajadores auxiliares en actividades administrativas",
            "Comerciantes, empleados en ventas y agentes de ventas",
            "Trabajadores en servicios personales y de vigilancia",
            "Trabajadores en actividades agrícolas, ganaderas, forestales, caza y pesca",
            "Trabajadores artesanales, en la construcción y otros oficios",
            "Operadores de maquinaria industrial, ensambladores, choferes y conductores de transporte",
            "Trabajadores en actividades elementales y de apoyo",
            "Otros" };
        public string? ocupacionOtra { get; set; } //nuevo la pregunta es describa su ocupacion
        //ver si podemos cargar laos codigos de inegi para localidad
        public string? lugardeNacimientoAlcaldia { get; set; }//alcadia
        public string? lugardeNacimientoMunicipio { get; set; }//segundo
        public string? lugardeNacimientoEstado { get; set; }//primero
        public string? lugardeNacimientoPais { get; set; }

        public string? lugardeResidenciaAlcaldia { get; set; }
        public string? lugardeResidenciaMunicipio { get; set; }
        public string? lugardeResidenciaEstado { get; set; }

        public int personasEnCasa { get; set; }
        public int personasAportanGastos { get; set; }

        public string? principalProveedorEconomico { get; set; }
        public List<string> ProvedoresEconomicos = new List<string> { "Paciente", "Pareja", "Hijos", "Mamá", "Papá", "Otros" };
        public string? principalProveedorEconomicoOtro { get; set; }

        public string? jefeJefaHogar { get; set; }
        public List<string> JefesHogar = new List<string> { "Paciente", "Pareja", "Hijos", "Mamá", "Papá", "Otros" };
        public string? jefeJefaHogarOtro { get; set; }

        public string? ingresoMensualHogar { get; set; } //solo las categorias
        public List<string> IngresosMensuales = new List<string> {
            "Sin ingresos",
            "Menos de $4300",
            "$4301-$8600",
            "$8601-$13200",
            "$13201-$17800",
            "$17801-$22100",
            "$22101-$31000",
            "$31001-$40000",
            "$40001-$50000",
            "Más de $50000",
            "No sabe",
            "No contesta" };

        public string? tipoDeCasa { get; set; }
        public List<string> TiposDeCasa = new List<string> { "Propia", "Rentada", "De un familiar o prestada", "Ocupada en otra situación", "Otra" };

        public string? tipoDeTrasplante { get; set; }
        public List<string> TiposDeTrasplante = new List<string> { "Trasplante renal donador vivo", "Trasplante renal donador fallecido", "Trasplante hepático", "Trasplante de córnea" };

        public int diaTrasplante { get; set; }
        public int mesTrasplante { get; set; }
        public int anioTrasplante { get; set; }
        public int diaTieneTrasplante { get; set; }//CALCULAR automatico fecha de hoy //paginap 
        public int mesTieneTrasplante { get; set; }//paginap 
        public int anioTieneTrasplante { get; set; }//paginap 
        public int diaDiagnostico { get; set; }
        public int mesDiagnostico { get; set; }
        public int anioDiagnostico { get; set; }

        //anexo 2
        public List<string> ResilenciaQuestionsText = new List<string> {
            "Lo que me ha ocurrido en el pasado me hace sentir confianza para enfrentar nuevos retos",
            "Sé dónde buscar ayuda",
            "Soy una persona fuerte",
            "Sé muy bien lo que quiero",
            "Tengo el control de mi vida",
            "Me gustan los retos",
            "Me esfuerzo por alcanzar mis metas",
            "Estoy orgulloso de mis logros",
            "Sé que tengo habilidades",
            "Creer en mí mismo me ayuda a superar los momentos difíciles",
            "Creo que voy a tener éxito",
            "Sé cómo lograr mis objetivos",
            "Pase lo que pase siempre encontraré una solución",
            "Mi futuro pinta bien",
            "Sé que puedo resolver mis problemas personales",
            "Estoy satisfecho conmigo mismo",
            "Tengo planes realistas para el futuro",
            "Confío en mis decisiones",
            "Cuando no estoy bien, sé que vendrán tiempos mejores",
            "Me siento cómodo con otras personas",
            "Me es fácil establecer contactos con nuevas personas",
            "Me es fácil hacer nuevos amigos",
            "Es fácil para mí tener un buen tema de conversación ",
            "Fácilmente me adapto a situaciones nuevas",
            "Es fácil para mí hacer reír a otras personas",
            "Disfruto de estar con otras personas",
            "Sé cómo comenzar una conversación ",
            "Tengo una buena relación con mi familia",
            "Disfruto de estar con mi familia",
            "En nuestra familia somos leales entre nosotros",
            "En nuestra familia disfrutamos de hacer actividades juntos",
            "Aún en momentos difíciles, nuestra familia tiene una actitud optimista hacia el futuro",
            "En nuestra familia coincidimos en relación a lo que consideramos importante en la vida",
            "Tengo amigos/familiares que realmente se preocupan por mi",
            "Tengo amigos/familiares que me apoyan",
            "Siempre tengo alguien que puede ayudarme cuando lo necesito",
            "Tengo amigos/familiares que me alientan",
            "Tengo amigos/familiares que valoran mis actividades",
            "Las reglas y la rutina hacen mi vida más fácil",
            "Mantengo mi rutina aún en momentos difíciles",
            "Prefiero planear mis actividades",
            "Trabajo mejor cuando tengo metas",
            "Soy bueno para organizar mi tiempo"
            };
        public List<ResilenciaQuestion> ResilenciaQuestions { get; set; } = new List<ResilenciaQuestion>();
        public List<string> ResilenciaAnswers { get; set; } = new List<string> { "Totalmente en desacuerdo", "En desacuerdo", "De acuerdo", "Totalmente de acuerdo" };

        //Anexo 3
        public List<string> AfrontamientoQuestionsText = new List<string> {
            "Se ocupa de otras actividades para no pensar en su trasplante",
            "Analiza las causas de su trasplante",
            "A su manera intenta realizar sus actividades",
            "Busca informarse acerca de su trasplante",
            "Se critica a usted mismo (a)",
            "Trata de que no se le cierren las puertas",
            "Trata de guardar sus sentimientos para usted",
            "Busca lo positivo de la situación que está pasando",
            "Duerme más de lo normal",
            "Expresa su enojo con los demás sin importar lo que piensen",
            "Trata de que los demás no se den cuenta de lo que siente",
            "Evade las conversaciones que tienen que ver con su trasplante",
            "Se dice a sí mismo (a) cosas que le hagan sentir mejor",
            "Trata de pensar en otras cosas que no sea su trasplante",
            "Tiene fe en que Dios remedie la situación",
            "Descarga su mal humor con los demás",
            "Acepta la simpatía y comprensión de cualquier persona",
            "Busca la forma de hacer algo creativo",
            "Si tiene un mal trato hacia los demás, se disculpa",
            "Deja que sus sentimientos salgan de alguna manera",
            "Se siente mucho mejor que cuando empezó con los síntomas de la situación de salud",
            "Trata de no pensar en el trasplante",
            "Procura descansar",
            "Intenta sentirse mejor comiendo",
            "En ocasiones ingiere alcohol para olvidarse del problema que le ha generado el trasplante",
            "Trata de sentirse mejor tomando otro medicamento",
            "Conserva su orgullo y no se deja vencer",
            "Descubre lo importante que es la vida",
            "En general, evita estar con la gente",
            "No permite que su trasplante le afecte emocionalmente",
            "Se sale de casillas",
            "Platica sobre su trasplante con algún familiar o amigo (a) de confianza",
            "Evita que otros se enteren de su trasplante",
            "Da poca importancia a su trasplante",
            "Busca alternativas para solucionar los síntomas que padece",
            "Asiste a la iglesia",
            "Trata de ocultar su malestar",
            "Se aleja temporalmente de los problemas (vacaciones, salidas, etc.)",
            "Si tiene ganas de llorar, llora",
            "Se involucra en otras cosas que le hagan olvidar su trasplante",
            "Hace frente a su trasplante poniendo en marcha varias soluciones",
            "Deja que las cosas sigan su curso",
            "Trata de controlar su estrés (tensión) valiéndose de sus habilidades personales",
            "Experimenta tristeza cuando no puede realizar sus actividades",
            "Se esfuerza doblemente para que las cosas salgan bien",
            "Sigue con sus tratamientos",
            "Trata de que sus sentimientos no interfieran",
            "Desearía que desapareciera su situación",
            "Tiene fantasías acerca de cómo le gustaría que fueran las cosas",
            "Se pone a meditar",
            "Habla con alguien acerca de cómo se siente",
            "Se mantiene estable y lucha por lo que quiere",
            "Se desquita con los demás",
            "Trata de resignarse con lo que sucede",
            "Generalmente expresa su tristeza",
            "Piensa que las cosas podrían ser peor",
            "Procura relajarse",
            "Se vuelve pesimista con las cosas que le pasan",
            "Intenta mantener la calma",
            "Piensa que puede solucionar sus problemas sin la ayuda de los demás",
            "Intenta informarse de alguna manera de su trasplante",
            "Se siente melancólico (a)"
        };
        public List<AfrontamientoQuestion> AfrontamientoQuestions { get; set; } = new List<AfrontamientoQuestion>();
        public List<string> AfrontamientoAnswers { get; set; } = new List<string> { "Siempre", "Casi siempre", "A veces", "Rara vez", "Casi nunca", "Nunca" };

        public List<string> Freq1 = new List<string> { "siempre", "casi siempre", "a veces", "rara vez", "casi nunca", "nunca" };
        public List<string> Satisfac = new List<string> { "muy satisfecho", "regularmente satisfecho", "poco satisfecho", "nada satisfecho" };
        public List<string> SentimientosVals = new List<string> { "1", "2", "3", "4", "5", "6" };

        public string? QuienApoyoEcoPas { get; set; }
        public string? SatisfacApoyoEcoPas { get; set; }
        
        public string? QuienApoyoDomesticaPas { get; set; }
        public string? SatisfacApoyoDomesticaPas { get; set; }
  
        public string? QuienApoyoCitaPas { get; set; }
        public string? SatisfacApoyoCitaPas { get; set; }

        public string? QuienApoyoPersonalPas { get; set; }
        public string? SatisfacApoyoPersonalPas { get; set; }

        public string? PedirPrestadoPas { get; set; }
        public string? PedirPrestadoQuienPas { get; set; }
        public string? PedirPrestadoTiempoPas { get; set; }

        public string? Triste_ContentoPas { get; set; }
        public string? Inseguro_SeguroPas { get; set; }
        public string? Pesimista_OptimistaPas { get; set; }
        public string? Desagradable_AgradablePas { get; set; }
        public string? Inutil_ÚtilPas { get; set; }
        public string? Preocupado_SinpreocupacionPas { get; set; }
        public string? Incomodo_ComodoPas { get; set; }
        public string? Incapaz_CapazPas { get; set; }
        public string? Intranquilo_TranquiloPas { get; set; }
        public string? Asustado_RelajadoPas { get; set; }
        public string? Incomprendido_ComprendidoPas { get; set; }
        public string? Infeliz_FelizPas { get; set; }
        public string? Solo_AcompanadoPas { get; set; }
        public string? Sinamor_AmadoPas { get; set; }

        public string? QuienApoyoEco { get; set; }
        public string? SatisfacApoyoEco { get; set; }

        public string? QuienApoyoDomestica { get; set; }
        public string? SatisfacApoyoDomestica { get; set; }

        public string? QuienApoyoCita { get; set; }
        public string? SatisfacApoyoCita { get; set; }

        public string? QuienApoyoPersonal { get; set; }
        public string? SatisfacApoyoPersonal { get; set; }

        public string? PedirPrestado { get; set; }
        public string? PedirPrestadoQuien { get; set; }

        public string? Triste_Contento { get; set; }
        public string? Inseguro_Seguro { get; set; }
        public string? Pesimista_Optimista { get; set; }
        public string? Desagradable_Agradable { get; set; }
        public string? Inutil_Útil { get; set; }
        public string? Preocupado_Sinpreocupacion { get; set; }
        public string? Incomodo_Comodo { get; set; }
        public string? Incapaz_Capaz { get; set; }
        public string? Intranquilo_Tranquilo { get; set; }
        public string? Asustado_Relajado { get; set; }
        public string? Incomprendido_Comprendido { get; set; }
        public string? Infeliz_Feliz { get; set; }
        public string? Solo_Acompanado { get; set; }
        public string? Sinamor_Amado { get; set; }

        public string? QuienInfoPas { get; set; }
        public string? QuienFoletosArticulosRevistasPas { get; set; }
        public string? QuienConsejosPas { get; set; }
        public string? ConsejoFrecPas { get; set; }

        public string? ConsultaControlPas { get; set; }

        public string? TerapiasPsicologicaPas { get; set; }

        public string? Malinformado_BieninformadoPas { get; set; }
        public string? Intranquilo_TranquiloInfoPas { get; set; }
        public string? Desinteresdelosdemas_InteresdelosdemasPas { get; set; }
        public string? Asustado_RelajadoInfoPas { get; set; }
        public string? Enojado_SerenoPas { get; set; }
        public string? Desmotivado_MotivadoPas { get; set; }
        public string? Insatisfecho_SatisfechoPas { get; set; }
        public string? Inconforme_ConformePas { get; set; }


        public string? QuienInfo { get; set; }
        public string? QuienFoletosArticulosRevistas { get; set; }
        public string? QuienConsejos { get; set; }
        public string? ConsejoFrec { get; set; }
        public string? ConsultaControl { get; set; }
        public string? TerapiasPsicologica { get; set; }

        public string? Malinformado_Bieninformado { get; set; }
        public string? Intranquilo_TranquiloInfo { get; set; }
        public string? Desinteresdelosdemas_Interesdelosdemas { get; set; }
        public string? Asustado_RelajadoInfo { get; set; }
        public string? Enojado_Sereno { get; set; }
        public string? Desmotivado_Motivado { get; set; }
        public string? Insatisfecho_Satisfecho { get; set; }
        public string? Inconforme_Conforme { get; set; }

        public string? QuienPlatica { get; set; }
        public string? QuienPlaticaFrec { get; set; }
        public string? QuienCarino { get; set; }
        public string? QuienCarinoFrec { get; set; }
        public string? QuienInteres { get; set; }
        public string? QuienInteresFrec { get; set; }
        public string? QuienBurlaFrec { get; set; }
        public string? QuienBurla { get; set; }

        public string? Desagradable_AgradablePersonas { get; set; }
        public string? Incomodo_ComodoPersonas { get; set; }
        public string? Solo_AcompanadoPersonas { get; set; }
        public string? Desmotivado_MotivadoPersonas { get; set; }
        public string? Ignorado_EscuchadoPersonas { get; set; }
        public string? Sinamor_AmadoPersonas { get; set; }
        public string? Incomprendido_ComprendidoPersonas { get; set; }
        public string? Infeliz_FelizPersonas { get; set; }
        public string? Desalentado_EsperanzadoPersonas { get; set; }
        public string? Fragil_FuertePersonas { get; set; }

        //Anexo 4
        public string? SaludEs { get; set; }
        public List<string> SaludEscala { get; set; } = new List<string> { "Excelente", "Muy Buena", "Buena", "Regular", "Mala", "Nunca" };
        public string? SaludCom { get; set; }
        public List<string> SaludComEscala { get; set; } = new List<string> { "Mucho mejor ahora que hace un año", 
                                                                              "Algo mejor ahora que hace un año",
                                                                              "Mas o menos igual ahora que hace un año",
                                                                              "Algo peor ahora que hace un año",
                                                                              "Mucho peor ahora que hace un año" };
    }

    public class ResilenciaQuestion
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property back to Patient
        public string? Text { get; set; }
        public string? SelectedAnswer { get; set; }
    }

    public class AfrontamientoQuestion
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; } // Navigation property back to Patient
        public string? Text { get; set; }
        public string? SelectedAnswer { get; set; }
    }
} 
