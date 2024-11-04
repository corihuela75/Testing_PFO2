Práctica Formativa 2: Metodología de Pruebas de Sistemas
Vamos a implementar pruebas para un sistema simple de gestión de productos que incluya
funcionalidades como agregar producto, calcular precio total con impuestos y buscar
producto por nombre. Las clases deben estar en una carpeta aparte.

# Crear una clase llamada Product con las siguientes propiedades:
- id
- name
- price
- category: "Electrónica" o "Alimentos".
  
# Crear una clase llamada ProductManager con los siguientes métodos:

- addProduct: Agrega un nuevo producto al sistema (una lista vacía).
- calculateTotalPrice: Calcula el precio total de un producto incluyendo los impuestos.
- findProductByName: Busca un producto por su nombre y devuelve su información (a
partir de su id, una opción es utilizar un método como Find).

# Reglas del negocio:

- El precio base de un producto no puede ser negativo.
- El precio total de un producto se calcula agregando un impuesto del 10% si la
categoría es "Electrónica" y del 5% si es "Alimentos".

# Pruebas:

- Verificar que un producto se crea correctamente con un id, name, price y category
válidos.
- Verificar que addProduct agrega correctamente un producto a la lista interna.
- Agregar varios productos y verificar que findProductByName los encuentre
correctamente por nombre.
- Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos
para productos de la categoría "Electrónica".
- Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos
para productos de la categoría "Alimentos".

Lo que deben adjuntar en el espacio de entrega es la carpeta entera, con todo lo que
tiene dentro.
