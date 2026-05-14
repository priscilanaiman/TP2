class SugeridorReceta
{
    public string nombre {get;set;}
    public DateTime fechaNacimiento {get;set;}
    public string tipoComida {get;set;}
    public int presupuesto {get;set;}
    public int cantComensales {get;set;}
    
    public SugeridorReceta(){}

    public SugeridorReceta(string nombre, DateTime fechaNacimiento, string tipoComida, int presupuesto, int cantComensales)
    {
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.tipoComida = tipoComida;
        this.presupuesto = presupuesto;
        this.cantComensales = cantComensales;
    }
    public int calcularEdad()
    {
        int edad;
        edad = this.fechaNacimiento.Year - DateTime.Today.Year;
        if(this.fechaNacimiento.Month > DateTime.Today.Month)
        {
            edad -= 1;
        }
        else if (this.fechaNacimiento.Month == DateTime.Today.Month)
        {
            if (this.fechaNacimiento.Day > DateTime.Today.Day)
            {
                edad -= 1;
            } 
        }
        return edad;
    }
    public string DeterminarPlato()
    {
        if(this.tipoComida == "Caliente" && this.presupuesto < 3000)
        {
            return "Fideos con manteca";
        }
        else if (this.tipoComida == "Caliente" && this.presupuesto <= 7000 && this.presupuesto >= 3000)
        {
            return "Arroz con verduras salteadas";
        }
        else if (this.tipoComida == "Caliente" && this.presupuesto > 7000)
        {
            return "Pollo al horno con guarnición";
        }
        else if(this.tipoComida == "Frio" && this.presupuesto < 3000)
        {
            return "Ensalada simple";
        }
        else if (this.tipoComida == "Frio" && this.presupuesto <= 7000 && this.presupuesto >= 3000)
        {
            return "Ensalada completa con proteína";
        }
        else
        {
            return "Tabla de fiambres y quesos";
        }
    }
    public int CalcularTiempo()
    {
        if(this.tipoComida == "Caliente" && (this.cantComensales == 1 || this.cantComensales == 2 || this.cantComensales == 3))
        {
            return 20;
        }
        else if (this.tipoComida == "Caliente" && this.cantComensales < 7 && this.cantComensales > 4)
        {
            return 40;
        }
        else if (this.tipoComida == "Caliente" && this.cantComensales > 8)
        {
            return 80;
        }
        else if(this.tipoComida == "Frio" && (this.cantComensales == 1 || this.cantComensales == 2 || this.cantComensales == 3))
        {
            return 10;
        }
        else if (this.tipoComida == "Frio" && this.cantComensales < 7 && this.cantComensales > 4)
        {
            return 20;
        }
        else
        {
            return 40;
        }
    }
    public string DeterminarDificultad()
    {
        if (this.presupuesto < 3000  &&  (this.cantComensales == 1 || this.cantComensales == 2 || this.cantComensales == 3))
        {
            return "Principiante";
        }
        else if (this.presupuesto < 3000  &&  this.cantComensales <= 7 && this.cantComensales >= 4 || this.presupuesto >= 3000 && this.presupuesto <= 7000 && (this.cantComensales == 1 || this.cantComensales == 2 || this.cantComensales == 3) || this.presupuesto >= 3000 && this.presupuesto <= 7000 && this.cantComensales >= 4 || this.presupuesto > 7000 && this.cantComensales <= 7 && this.cantComensales >= 1)
        {
            return "Intermedio";
        }
        else if (this.presupuesto >= 7000 && cantComensales >= 8)
        {
            return "Avanzado";
        }
        else
        {
            return "No se pudo calcular nivel de dificultad";
        }
    }
}