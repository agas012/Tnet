﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tnet.Data;

#nullable disable

namespace Tnet.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240312225053_upd2")]
    partial class upd2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tnet.Entities.AfrontamientoQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("SelectedAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("AfrontamientoQuestions");
                });

            modelBuilder.Entity("Tnet.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AfrontamientoAnswers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asustado_Relajado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asustado_RelajadoInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asustado_RelajadoInfoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asustado_RelajadoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsejoFrec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsejoFrecPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsultaControl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsultaControlPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desagradable_Agradable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desagradable_AgradablePas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desagradable_AgradablePersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desalentado_EsperanzadoPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desinteresdelosdemas_Interesdelosdemas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desinteresdelosdemas_InteresdelosdemasPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desmotivado_Motivado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desmotivado_MotivadoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desmotivado_MotivadoPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECUNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enojado_Sereno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enojado_SerenoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fragil_FuertePersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HablalenguaIndigena")
                        .HasColumnType("bit");

                    b.Property<string>("Ignorado_EscuchadoPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incapaz_Capaz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incapaz_CapazPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incomodo_Comodo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incomodo_ComodoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incomodo_ComodoPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incomprendido_Comprendido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incomprendido_ComprendidoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Incomprendido_ComprendidoPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inconforme_Conforme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inconforme_ConformePas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Infeliz_Feliz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Infeliz_FelizPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Infeliz_FelizPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Insatisfecho_Satisfecho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Insatisfecho_SatisfechoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inseguro_Seguro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inseguro_SeguroPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intranquilo_Tranquilo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intranquilo_TranquiloInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intranquilo_TranquiloInfoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intranquilo_TranquiloPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inutil_Útil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inutil_ÚtilPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Malinformado_Bieninformado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Malinformado_BieninformadoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedirPrestado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedirPrestadoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedirPrestadoQuien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedirPrestadoQuienPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedirPrestadoTiempoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PertenecegrupoEtnico")
                        .HasColumnType("bit");

                    b.Property<string>("Pesimista_Optimista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesimista_OptimistaPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preocupado_Sinpreocupacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preocupado_SinpreocupacionPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoCitaPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoDomestica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoDomesticaPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoEco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoEcoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoPersonal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienApoyoPersonalPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienBurla")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienBurlaFrec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienCarino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienCarinoFrec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienConsejos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienConsejosPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienFoletosArticulosRevistas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienFoletosArticulosRevistasPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienInfoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienInteres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienInteresFrec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienPlatica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuienPlaticaFrec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResilenciaAnswers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaludCom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaludComEscala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaludEs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaludEscala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoCitaPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoDomestica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoDomesticaPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoEco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoEcoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoPersonal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SatisfacApoyoPersonalPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinamor_Amado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinamor_AmadoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinamor_AmadoPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Solo_Acompanado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Solo_AcompanadoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Solo_AcompanadoPersonas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurnameM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurnameP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TerapiasPsicologica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TerapiasPsicologicaPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Triste_Contento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Triste_ContentoPas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("anioDiagnostico")
                        .HasColumnType("int");

                    b.Property<int>("anioTieneTrasplante")
                        .HasColumnType("int");

                    b.Property<int>("anioTrasplante")
                        .HasColumnType("int");

                    b.Property<int>("aniosdeestudio")
                        .HasColumnType("int");

                    b.Property<int>("diaDiagnostico")
                        .HasColumnType("int");

                    b.Property<int>("diaTieneTrasplante")
                        .HasColumnType("int");

                    b.Property<int>("diaTrasplante")
                        .HasColumnType("int");

                    b.Property<string>("estadocivilSeleccionado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fechadeaplicacionAnio")
                        .HasColumnType("int");

                    b.Property<int>("fechadeaplicacionDia")
                        .HasColumnType("int");

                    b.Property<int>("fechadeaplicacionMes")
                        .HasColumnType("int");

                    b.Property<int>("fechadenacimientoAnio")
                        .HasColumnType("int");

                    b.Property<int>("fechadenacimientoDia")
                        .HasColumnType("int");

                    b.Property<int>("fechadenacimientoMes")
                        .HasColumnType("int");

                    b.Property<string>("generoOtro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("generoSeleccionado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("grupoEtnicoCual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ingresoMensualHogar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jefeJefaHogar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jefeJefaHogarOtro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lenguaIndigenaCual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugardeNacimientoAlcaldia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugardeNacimientoEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugardeNacimientoMunicipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugardeNacimientoPais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugardeResidenciaAlcaldia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugardeResidenciaEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugardeResidenciaMunicipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mesDiagnostico")
                        .HasColumnType("int");

                    b.Property<int>("mesTieneTrasplante")
                        .HasColumnType("int");

                    b.Property<int>("mesTrasplante")
                        .HasColumnType("int");

                    b.Property<int>("numcuestionario")
                        .HasColumnType("int");

                    b.Property<string>("ocupacionOtra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ocupacionSeleccionada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personasAportanGastos")
                        .HasColumnType("int");

                    b.Property<int>("personasEnCasa")
                        .HasColumnType("int");

                    b.Property<string>("principalProveedorEconomico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("principalProveedorEconomicoOtro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionOtra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionSeleccionada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoDeCasa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoDeTrasplante")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Tnet.Entities.ResilenciaQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("SelectedAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("ResilenciaQuestions");
                });

            modelBuilder.Entity("Tnet.Entities.AfrontamientoQuestion", b =>
                {
                    b.HasOne("Tnet.Entities.Patient", "Patient")
                        .WithMany("AfrontamientoQuestions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Tnet.Entities.ResilenciaQuestion", b =>
                {
                    b.HasOne("Tnet.Entities.Patient", "Patient")
                        .WithMany("ResilenciaQuestions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Tnet.Entities.Patient", b =>
                {
                    b.Navigation("AfrontamientoQuestions");

                    b.Navigation("ResilenciaQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
