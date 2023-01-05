//CODE WARS CHALLENGE - 'Who likes it?' - RESOLVIDO
/*
Você provavelmente conhece o sistema de "curtir" do Facebook e outras páginas. 
As pessoas podem "curtir" postagens de blog, fotos ou outros itens. Queremos criar o texto que deve ser exibido ao lado de tal item.
Implemente a função que recebe um array contendo os nomes das pessoas que gostam de um item. 
Ele deve retornar o texto de exibição conforme os exemplos:

[] --> "no one likes this"
["Peter"]-- > "Peter likes this"
["Jacob", "Alex"]-- > "Jacob and Alex like this"
["Max", "John", "Mark"]-- > "Max, John and Mark like this"
["Alex", "Jacob", "Mark", "Max"]-- > "Alex, Jacob and 2 others like this"
*/

static string Likes(string[] name)
{
    int len = name.Length;
    string response = string.Empty;

    switch (len)
    {
        case 0:
             response = "no one likes this";
            break;
        case 1:
             response = $"{name[0]} likes this";
            break;
        case 2:
             response = $"{name[0]} and {name[1]} like this";
            break;
        case 3:
             response = $"{name[0]}, {name[1]} and {name[2]} like this";
            break;
        case > 3:
             response = $"{name[0]}, {name[1]} and {len - 2} others like this";
            break;
        default:
            break;
    }
    return response;
}