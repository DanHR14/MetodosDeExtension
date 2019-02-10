<h1>Metodos de extensión</h1>

En este ejemplo vamos a ver un método de extensión para string.

Este método lo que va hacer es saludar a nuestro usuario cuando indique su nombre. Para ello, generamos el método:

    public static string saludar(this string Nombre)
    
De esta manera hemos añadido a string este método sin alterar la clase original.