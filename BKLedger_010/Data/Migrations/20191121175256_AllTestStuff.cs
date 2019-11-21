using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BKLedger_010.Data.Migrations
{
    public partial class AllTestStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "conv0mm_ManyStudent",
                columns: table => new
                {
                    DudeIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv0mm_ManyStudent", x => x.DudeIdee);
                });

            migrationBuilder.CreateTable(
                name: "conv1_OneClass",
                columns: table => new
                {
                    conv1_OneClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv1_OneClass", x => x.conv1_OneClassId);
                });

            migrationBuilder.CreateTable(
                name: "conv2_OneClass",
                columns: table => new
                {
                    Class0Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv2_OneClass", x => x.Class0Id);
                });

            migrationBuilder.CreateTable(
                name: "conv3_OneClass",
                columns: table => new
                {
                    ClassIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv3_OneClass", x => x.ClassIdee);
                });

            migrationBuilder.CreateTable(
                name: "conv4_OneClass",
                columns: table => new
                {
                    ClassIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv4_OneClass", x => x.ClassIdee);
                });

            migrationBuilder.CreateTable(
                name: "O2M_Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_O2M_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Test_Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: true),
                    EnrollmentDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M2M_Course",
                columns: table => new
                {
                    CourseId = table.Column<string>(nullable: false),
                    CourseName = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<string>(nullable: true),
                    CreatedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M2M_Course", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_M2M_Course_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M2M_Course_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "M2M_Student",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    StudentName = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<string>(nullable: true),
                    CreatedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M2M_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_M2M_Student_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M2M_Student_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conv0mm_ManyClass",
                columns: table => new
                {
                    ClassIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassName = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    MobserDudeIdee = table.Column<int>(nullable: true),
                    TopDogDudeIdee = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv0mm_ManyClass", x => x.ClassIdee);
                    table.ForeignKey(
                        name: "FK_conv0mm_ManyClass_conv0mm_ManyStudent_MobserDudeIdee",
                        column: x => x.MobserDudeIdee,
                        principalTable: "conv0mm_ManyStudent",
                        principalColumn: "DudeIdee",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_conv0mm_ManyClass_conv0mm_ManyStudent_TopDogDudeIdee",
                        column: x => x.TopDogDudeIdee,
                        principalTable: "conv0mm_ManyStudent",
                        principalColumn: "DudeIdee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conv1_ManyStudent",
                columns: table => new
                {
                    conv1_ManyStudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    THEclassconv1_OneClassId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv1_ManyStudent", x => x.conv1_ManyStudentId);
                    table.ForeignKey(
                        name: "FK_conv1_ManyStudent_conv1_OneClass_THEclassconv1_OneClassId",
                        column: x => x.THEclassconv1_OneClassId,
                        principalTable: "conv1_OneClass",
                        principalColumn: "conv1_OneClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conv2_ManyStudent",
                columns: table => new
                {
                    Student0Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    conv2_OneClassClass0Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv2_ManyStudent", x => x.Student0Id);
                    table.ForeignKey(
                        name: "FK_conv2_ManyStudent_conv2_OneClass_conv2_OneClassClass0Id",
                        column: x => x.conv2_OneClassClass0Id,
                        principalTable: "conv2_OneClass",
                        principalColumn: "Class0Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conv3_ManyStudent",
                columns: table => new
                {
                    DudeIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    ClassOfTheStudentClassIdee = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv3_ManyStudent", x => x.DudeIdee);
                    table.ForeignKey(
                        name: "FK_conv3_ManyStudent_conv3_OneClass_ClassOfTheStudentClassIdee",
                        column: x => x.ClassOfTheStudentClassIdee,
                        principalTable: "conv3_OneClass",
                        principalColumn: "ClassIdee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conv4_ManyStudent",
                columns: table => new
                {
                    DudeIdee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    KelaslassIdee = table.Column<int>(nullable: false),
                    ClassOfTheStudentClassIdee = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv4_ManyStudent", x => x.DudeIdee);
                    table.ForeignKey(
                        name: "FK_conv4_ManyStudent_conv4_OneClass_ClassOfTheStudentClassIdee",
                        column: x => x.ClassOfTheStudentClassIdee,
                        principalTable: "conv4_OneClass",
                        principalColumn: "ClassIdee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "O2M_EmployeeOfCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_O2M_EmployeeOfCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_O2M_EmployeeOfCompany_O2M_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "O2M_Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Test_Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Budget = table.Column<decimal>(type: "money", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    InstructorID = table.Column<int>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Department", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Test_Department_Test_Person_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Test_Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Test_OfficeAssignment",
                columns: table => new
                {
                    InstructorID = table.Column<int>(nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_OfficeAssignment", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_Test_OfficeAssignment_Test_Person_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Test_Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M2M_StudentCourse",
                columns: table => new
                {
                    StudentCourseId = table.Column<string>(nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<string>(nullable: true),
                    ModifiedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M2M_StudentCourse", x => x.StudentCourseId);
                    table.ForeignKey(
                        name: "FK_M2M_StudentCourse_M2M_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "M2M_Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M2M_StudentCourse_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M2M_StudentCourse_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_M2M_StudentCourse_M2M_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "M2M_Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conv0mm_Class_X_Student",
                columns: table => new
                {
                    PesonId = table.Column<int>(nullable: false),
                    KelasIdee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conv0mm_Class_X_Student", x => new { x.PesonId, x.KelasIdee });
                    table.ForeignKey(
                        name: "FK_conv0mm_Class_X_Student_conv0mm_ManyClass_KelasIdee",
                        column: x => x.KelasIdee,
                        principalTable: "conv0mm_ManyClass",
                        principalColumn: "ClassIdee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conv0mm_Class_X_Student_conv0mm_ManyStudent_PesonId",
                        column: x => x.PesonId,
                        principalTable: "conv0mm_ManyStudent",
                        principalColumn: "DudeIdee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test_Course",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Credits = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Course", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_Test_Course_Test_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Test_Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test_CourseAssignment",
                columns: table => new
                {
                    InstructorID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_CourseAssignment", x => new { x.CourseID, x.InstructorID });
                    table.ForeignKey(
                        name: "FK_Test_CourseAssignment_Test_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Test_Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_CourseAssignment_Test_Person_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Test_Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test_Enrollment",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    EnrollmentId = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test_Enrollment", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_Test_Enrollment_Test_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Test_Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_Enrollment_Test_Person_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Test_Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_conv0mm_Class_X_Student_KelasIdee",
                table: "conv0mm_Class_X_Student",
                column: "KelasIdee");

            migrationBuilder.CreateIndex(
                name: "IX_conv0mm_ManyClass_MobserDudeIdee",
                table: "conv0mm_ManyClass",
                column: "MobserDudeIdee");

            migrationBuilder.CreateIndex(
                name: "IX_conv0mm_ManyClass_TopDogDudeIdee",
                table: "conv0mm_ManyClass",
                column: "TopDogDudeIdee");

            migrationBuilder.CreateIndex(
                name: "IX_conv1_ManyStudent_THEclassconv1_OneClassId",
                table: "conv1_ManyStudent",
                column: "THEclassconv1_OneClassId");

            migrationBuilder.CreateIndex(
                name: "IX_conv2_ManyStudent_conv2_OneClassClass0Id",
                table: "conv2_ManyStudent",
                column: "conv2_OneClassClass0Id");

            migrationBuilder.CreateIndex(
                name: "IX_conv3_ManyStudent_ClassOfTheStudentClassIdee",
                table: "conv3_ManyStudent",
                column: "ClassOfTheStudentClassIdee");

            migrationBuilder.CreateIndex(
                name: "IX_conv4_ManyStudent_ClassOfTheStudentClassIdee",
                table: "conv4_ManyStudent",
                column: "ClassOfTheStudentClassIdee");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_Course_CreatedById",
                table: "M2M_Course",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_Course_ModifiedById",
                table: "M2M_Course",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_Student_CreatedById",
                table: "M2M_Student",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_Student_ModifiedById",
                table: "M2M_Student",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_StudentCourse_CourseId",
                table: "M2M_StudentCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_StudentCourse_CreatedById",
                table: "M2M_StudentCourse",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_StudentCourse_ModifiedById",
                table: "M2M_StudentCourse",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_StudentCourse_StudentId",
                table: "M2M_StudentCourse",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_O2M_EmployeeOfCompany_CompanyId",
                table: "O2M_EmployeeOfCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Course_DepartmentID",
                table: "Test_Course",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Test_CourseAssignment_InstructorID",
                table: "Test_CourseAssignment",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Department_InstructorID",
                table: "Test_Department",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Test_Enrollment_CourseId",
                table: "Test_Enrollment",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "conv0mm_Class_X_Student");

            migrationBuilder.DropTable(
                name: "conv1_ManyStudent");

            migrationBuilder.DropTable(
                name: "conv2_ManyStudent");

            migrationBuilder.DropTable(
                name: "conv3_ManyStudent");

            migrationBuilder.DropTable(
                name: "conv4_ManyStudent");

            migrationBuilder.DropTable(
                name: "M2M_StudentCourse");

            migrationBuilder.DropTable(
                name: "O2M_EmployeeOfCompany");

            migrationBuilder.DropTable(
                name: "Test_CourseAssignment");

            migrationBuilder.DropTable(
                name: "Test_Enrollment");

            migrationBuilder.DropTable(
                name: "Test_OfficeAssignment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "conv0mm_ManyClass");

            migrationBuilder.DropTable(
                name: "conv1_OneClass");

            migrationBuilder.DropTable(
                name: "conv2_OneClass");

            migrationBuilder.DropTable(
                name: "conv3_OneClass");

            migrationBuilder.DropTable(
                name: "conv4_OneClass");

            migrationBuilder.DropTable(
                name: "M2M_Course");

            migrationBuilder.DropTable(
                name: "M2M_Student");

            migrationBuilder.DropTable(
                name: "O2M_Company");

            migrationBuilder.DropTable(
                name: "Test_Course");

            migrationBuilder.DropTable(
                name: "conv0mm_ManyStudent");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Test_Department");

            migrationBuilder.DropTable(
                name: "Test_Person");
        }
    }
}
