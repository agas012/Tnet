using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tnet.Migrations
{
    /// <inheritdoc />
    public partial class upd1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numcuestionario = table.Column<int>(type: "int", nullable: false),
                    fechadeaplicacionDia = table.Column<int>(type: "int", nullable: false),
                    fechadeaplicacionMes = table.Column<int>(type: "int", nullable: false),
                    fechadeaplicacionAnio = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurnameP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurnameM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEnc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ECUNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechadenacimientoDia = table.Column<int>(type: "int", nullable: false),
                    fechadenacimientoMes = table.Column<int>(type: "int", nullable: false),
                    fechadenacimientoAnio = table.Column<int>(type: "int", nullable: false),
                    generoSeleccionado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    generoOtro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadocivilSeleccionado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aniosdeestudio = table.Column<int>(type: "int", nullable: false),
                    religionSeleccionada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    religionOtra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HablalenguaIndigena = table.Column<bool>(type: "bit", nullable: false),
                    lenguaIndigenaCual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PertenecegrupoEtnico = table.Column<bool>(type: "bit", nullable: false),
                    grupoEtnicoCual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ocupacionSeleccionada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ocupacionOtra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugardeNacimientoAlcaldia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugardeNacimientoMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugardeNacimientoEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugardeNacimientoPais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugardeResidenciaAlcaldia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugardeResidenciaMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugardeResidenciaEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personasEnCasa = table.Column<int>(type: "int", nullable: false),
                    personasAportanGastos = table.Column<int>(type: "int", nullable: false),
                    principalProveedorEconomico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    principalProveedorEconomicoOtro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jefeJefaHogar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jefeJefaHogarOtro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ingresoMensualHogar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoDeCasa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoDeTrasplante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diaTrasplante = table.Column<int>(type: "int", nullable: false),
                    mesTrasplante = table.Column<int>(type: "int", nullable: false),
                    anioTrasplante = table.Column<int>(type: "int", nullable: false),
                    diaTieneTrasplante = table.Column<int>(type: "int", nullable: false),
                    mesTieneTrasplante = table.Column<int>(type: "int", nullable: false),
                    anioTieneTrasplante = table.Column<int>(type: "int", nullable: false),
                    diaDiagnostico = table.Column<int>(type: "int", nullable: false),
                    mesDiagnostico = table.Column<int>(type: "int", nullable: false),
                    anioDiagnostico = table.Column<int>(type: "int", nullable: false),
                    ResilenciaAnswers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AfrontamientoAnswers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuienApoyoEcoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoEcoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienApoyoDomesticaPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoDomesticaPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienApoyoCitaPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoCitaPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienApoyoPersonalPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoPersonalPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedirPrestadoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedirPrestadoQuienPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedirPrestadoTiempoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Triste_ContentoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inseguro_SeguroPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pesimista_OptimistaPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desagradable_AgradablePas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inutil_ÚtilPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preocupado_SinpreocupacionPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incomodo_ComodoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incapaz_CapazPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intranquilo_TranquiloPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asustado_RelajadoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incomprendido_ComprendidoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Infeliz_FelizPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solo_AcompanadoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinamor_AmadoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienApoyoEco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoEco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienApoyoDomestica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoDomestica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienApoyoCita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoCita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienApoyoPersonal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfacApoyoPersonal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedirPrestado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedirPrestadoQuien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Triste_Contento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inseguro_Seguro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pesimista_Optimista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desagradable_Agradable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inutil_Útil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preocupado_Sinpreocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incomodo_Comodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incapaz_Capaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intranquilo_Tranquilo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asustado_Relajado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incomprendido_Comprendido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Infeliz_Feliz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solo_Acompanado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinamor_Amado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienInfoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienFoletosArticulosRevistasPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienConsejosPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsejoFrecPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultaControlPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerapiasPsicologicaPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Malinformado_BieninformadoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intranquilo_TranquiloInfoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desinteresdelosdemas_InteresdelosdemasPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asustado_RelajadoInfoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enojado_SerenoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desmotivado_MotivadoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Insatisfecho_SatisfechoPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inconforme_ConformePas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienFoletosArticulosRevistas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienConsejos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsejoFrec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultaControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerapiasPsicologica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Malinformado_Bieninformado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intranquilo_TranquiloInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desinteresdelosdemas_Interesdelosdemas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asustado_RelajadoInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enojado_Sereno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desmotivado_Motivado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Insatisfecho_Satisfecho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inconforme_Conforme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienPlatica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienPlaticaFrec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienCarino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienCarinoFrec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienInteres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienInteresFrec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienBurlaFrec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuienBurla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desagradable_AgradablePersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incomodo_ComodoPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solo_AcompanadoPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desmotivado_MotivadoPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ignorado_EscuchadoPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinamor_AmadoPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Incomprendido_ComprendidoPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Infeliz_FelizPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desalentado_EsperanzadoPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frágil_FuertePersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaludEs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaludEscala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaludCom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaludComEscala = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AfrontamientoQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfrontamientoQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AfrontamientoQuestions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResilenciaQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResilenciaQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResilenciaQuestions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AfrontamientoQuestions_PatientId",
                table: "AfrontamientoQuestions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_ResilenciaQuestions_PatientId",
                table: "ResilenciaQuestions",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AfrontamientoQuestions");

            migrationBuilder.DropTable(
                name: "ResilenciaQuestions");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
