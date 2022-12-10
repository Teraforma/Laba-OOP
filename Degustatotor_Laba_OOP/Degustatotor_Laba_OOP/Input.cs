using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degustatotor_Laba_OOP
{
    public partial class Input : Form
    {
        readonly static string _NameInputBackgroundText = "Name of product";
        readonly static string _TypeInputBackgroundText = "Type of Product";
        readonly static string _NoteInputBackgroundText = "Note";
        readonly static string _ShopInfoInputBackgroundText = "Info about shop (adress, etc)";
        readonly static string _VerificationDAtaInputBackgroundText = "When you had a probe";
        readonly static string _PriceInputBackgroundText = "Price of the Product";
        readonly static string _TasteInputBackgroundText = "Taste Points";
        readonly static string _HealtInputBackgroundText = "Health Points";


        readonly Controller _controls;

        internal Input(Controller Controlls )
        {
            InitializeComponent();
            LeaveChange(Note_TextBox, _NoteInputBackgroundText);
            LeaveChange(NameInput_TextBox, _NameInputBackgroundText);
            LeaveChange(TypeInput_TextBox, _TypeInputBackgroundText);
            LeaveChange(DateOnlyVerificate_TextBox, _VerificationDAtaInputBackgroundText);
            LeaveChange(ShopInfoInput_TextBox, _ShopInfoInputBackgroundText);
            LeaveChange(PriceInput_TextBox, _PriceInputBackgroundText);
            LeaveChange(TasteInput_TextBox, _TasteInputBackgroundText);
            LeaveChange(HealthyValueInput_TextBox, _HealtInputBackgroundText);

            this._controls = Controlls;
            Controlls.SetInputManager(LinkToController());
        }
        public TextBox[] LinkToController()
        {
            TextBox[] Arr = { NameInput_TextBox, Note_TextBox, HealthyValueInput_TextBox, TypeInput_TextBox, PriceInput_TextBox, DateOnlyVerificate_TextBox, ShopInfoInput_TextBox, TasteInput_TextBox };
            return Arr;
        }

        private static void EnterChange(TextBox ToChnage, string backgroundText)
        {
            if (ToChnage.Text == backgroundText)
            {
                ToChnage.Text = "";

                ToChnage.ForeColor = Color.Black;
            }

        }

        private static void LeaveChange(TextBox ToChnage, string backgroundText)
        {
            if (ToChnage.Text == "")
            {
                ToChnage.Text = backgroundText;
                ToChnage.ForeColor = Color.Silver;
            }
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void NameInput_TextBox_Enter(object sender, EventArgs e)
        {
            EnterChange(NameInput_TextBox, _NameInputBackgroundText);
        }

        private void NameInput_TextBox_Leave(object sender, EventArgs e)
        {
            LeaveChange(NameInput_TextBox, _NameInputBackgroundText);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeInput_TextBox_Leave(object sender, EventArgs e)
        {
            LeaveChange(TypeInput_TextBox, _TypeInputBackgroundText);
        }

        private void TypeInput_TextBox_Enter(object sender, EventArgs e)
        {
            EnterChange(TypeInput_TextBox, _TypeInputBackgroundText);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Note_Leave(object sender, EventArgs e)
        {
            LeaveChange(Note_TextBox, _NoteInputBackgroundText);
        }

        private void Note_Enter(object sender, EventArgs e)
        {
            EnterChange(Note_TextBox, _NoteInputBackgroundText);
        }

        private void DateOnlyVerificate_TextBox_Enter(object sender, EventArgs e)
        {
            EnterChange(DateOnlyVerificate_TextBox, _VerificationDAtaInputBackgroundText);
        }

        private void DateOnlyVerificate_TextBox_Leave(object sender, EventArgs e)
        {
            LeaveChange(DateOnlyVerificate_TextBox, _VerificationDAtaInputBackgroundText);
        }

        private void PriceToInput_TextBox(object sender, EventArgs e)
        {

        }

        private void PriceInput_TextBox_Enter(object sender, EventArgs e)
        {
            EnterChange(PriceInput_TextBox, _PriceInputBackgroundText);
        }

        private void PriceInput_TextBox_Leave(object sender, EventArgs e)
        {
            LeaveChange(PriceInput_TextBox, _PriceInputBackgroundText);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ShopInfoInput_TextBox_Enter(object sender, EventArgs e)
        {
            EnterChange(ShopInfoInput_TextBox, _ShopInfoInputBackgroundText);
        }

        private void ShopInfoInput_TextBox_Leave(object sender, EventArgs e)
        {
            LeaveChange(ShopInfoInput_TextBox, _ShopInfoInputBackgroundText);
        }

        private void Note_TextChanged(object sender, EventArgs e)
        {

        }

        private void TasteInput_TextBox_Enter(object sender, EventArgs e)
        {
            EnterChange(TasteInput_TextBox, _TasteInputBackgroundText);
        }

        private void TasteInput_TextBox_Leave(object sender, EventArgs e)
        {
            LeaveChange(TasteInput_TextBox, _TasteInputBackgroundText);
        }

        private void TasteInput_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HealthyValueInput_TextBox_Enter(object sender, EventArgs e)
        {
            EnterChange(HealthyValueInput_TextBox, _HealtInputBackgroundText);
        }

        private void HealthyValueInput_TextBox_Leave(object sender, EventArgs e)
        {
            LeaveChange(HealthyValueInput_TextBox, _HealtInputBackgroundText);
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            _controls.CreateNewProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controls.EditData();
        }

        private void DateOnlyVerificate_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            _controls.Sort();
        }
    }
}
