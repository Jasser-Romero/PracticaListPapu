using Domain.Entities.Activos;
using Domain.Enums.Activos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios.Activos_Fijos
{
    public partial class FrmActivos : Form
    {
        public FrmActivos()
        {
            InitializeComponent();
        }

        private void FrmActivos_Load(object sender, EventArgs e)
        {
            cmbTiposActivos.Items.AddRange(Enum.GetValues(typeof(TipoActivoFijo)).Cast<object>().ToArray());
        }

        private void PopulateActivoFijo(List<ActivoFijo> list)
        {
            ActivoFijo af = new ActivoFijo()
            {
                Id = 1,
                NombreActivo = "Empire State",
                CodigoActivo = "0000001",
                Descripcion = "Propiedad privada",
                FechaAdquisicion = DateTime.Now,
                ValorActivo = 500.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Edificio,
                MetodoDepreciacion = MetodoDepreciacion.LineaRecta
            };
            list.Add(af);

            list.Add(new ActivoFijo()
            {
                Id = 2,
                NombreActivo = "Asus Rog",
                CodigoActivo = "0000002",
                Descripcion = "Gran potencia",
                FechaAdquisicion = new DateTime(2018, 10, 03),
                ValorActivo = 600.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.EquipoComputo,
                MetodoDepreciacion = MetodoDepreciacion.LineaRecta
            });
            list.Add(new ActivoFijo()
            {
                Id = 3,
                NombreActivo = "Ferrari",
                CodigoActivo = "0000003",
                Descripcion = "Lujoso",
                FechaAdquisicion = new DateTime(2019, 11, 25),
                ValorActivo = 700.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Vehiculo,
                MetodoDepreciacion = MetodoDepreciacion.SDAIncremental
            });
            list.Add(new ActivoFijo()
            {
                Id = 4,
                NombreActivo = "Maquina de coser",
                CodigoActivo = "0000004",
                Descripcion = "Util",
                FechaAdquisicion = new DateTime(2021, 11, 10),
                ValorActivo = 800.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Maquinaria,
                MetodoDepreciacion = MetodoDepreciacion.LineaRecta
            });
            list.Add(new ActivoFijo()
            {
                Id = 5,
                NombreActivo = "Torre",
                CodigoActivo = "0000005",
                Descripcion = "Turismo",
                FechaAdquisicion = new DateTime(2022, 10, 09),
                ValorActivo = 900.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Edificio,
                MetodoDepreciacion = MetodoDepreciacion.SDAIncremental
            });
            list.Add(new ActivoFijo()
            {
                Id = 6,
                NombreActivo = "Toyota",
                CodigoActivo = "0000006",
                Descripcion = "Para uso de viajes",
                FechaAdquisicion = DateTime.Now,
                ValorActivo = 1000.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Vehiculo,
                MetodoDepreciacion = MetodoDepreciacion.LineaRecta
            });
            list.Add(new ActivoFijo()
            {
                Id = 7,
                NombreActivo = "Maquina de ensamblaje",
                CodigoActivo = "0000007",
                Descripcion = "Para uso exclusivo",
                FechaAdquisicion = DateTime.Now,
                ValorActivo = 1100.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Maquinaria,
                MetodoDepreciacion = MetodoDepreciacion.SDAIncremental
            });
            list.Add(new ActivoFijo()
            {
                Id = 8,
                NombreActivo = "Dell latitude",
                CodigoActivo = "0000008",
                Descripcion = "Para uso de trabajo",
                FechaAdquisicion = DateTime.Now,
                ValorActivo = 1200.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.EquipoComputo,
                MetodoDepreciacion = MetodoDepreciacion.LineaRecta
            });
            list.Add(new ActivoFijo()
            {
                Id = 9,
                NombreActivo = "Silla de oficina",
                CodigoActivo = "0000009",
                Descripcion = "Para sala del gerente",
                FechaAdquisicion = DateTime.Now,
                ValorActivo = 1300.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Mobiliario,
                MetodoDepreciacion = MetodoDepreciacion.LineaRecta
            });
            list.Add(new ActivoFijo()
            {
                Id = 10,
                NombreActivo = "Mesa de vidrio",
                CodigoActivo = "0000010",
                Descripcion = "Para sala de reunión",
                FechaAdquisicion = DateTime.Now,
                ValorActivo = 1400.00M,
                TipoActivoFijo = Domain.Enums.Activos.TipoActivoFijo.Mobiliario,
                MetodoDepreciacion = MetodoDepreciacion.SDAIncremental
            });

        }

        private void CmbTiposActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ActivoFijo> activoFijos = new List<ActivoFijo>();
            PopulateActivoFijo(activoFijos);

            switch (cmbTiposActivos.SelectedIndex)
            {
                case 0:
                    Clean();
                    activoFijos.Where(x => x.TipoActivoFijo == TipoActivoFijo.Edificio).ToList().ForEach(y => lbxActivosFijos.Items.Add(y));
                    break;
                case 1:
                    Clean();
                    activoFijos.Where(x => x.TipoActivoFijo == TipoActivoFijo.Vehiculo).ToList().ForEach(y => lbxActivosFijos.Items.Add(y));
                    break;
                case 2:
                    Clean();
                    activoFijos.Where(x => x.TipoActivoFijo == TipoActivoFijo.Maquinaria).ToList().ForEach(y => lbxActivosFijos.Items.Add(y));
                    break;
                case 3:
                    Clean();
                    activoFijos.Where(x => x.TipoActivoFijo == TipoActivoFijo.Mobiliario).ToList().ForEach(y => lbxActivosFijos.Items.Add(y));
                    break;
                case 4:
                    Clean();
                    activoFijos.Where(x => x.TipoActivoFijo == TipoActivoFijo.EquipoComputo).ToList().ForEach(y => lbxActivosFijos.Items.Add(y));
                    break;
            }

        }

        private void BtnListas_Click(object sender, EventArgs e)
        {
            if(lbxActivosFijos.SelectedItem == null)
            {
                MessageBox.Show("Error, no ha seleccionado objeto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           foreach(ActivoFijo item in lbxActivosFijos.SelectedItems){
                lbxActivosSeleccionados.Items.Add(item.NombreActivo);
            }
                

        }

        private void Clean()
        {
            lbxActivosFijos.Items.Clear();
        }

        private void BtnLimpiarLista_Click(object sender, EventArgs e)
        {
            lbxActivosSeleccionados.Items.Clear();
        }
    }
}
