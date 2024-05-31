namespace OrderAPI.Utils;

public static class ReadFile
{
    public static string ReadTemplateOrderCreated()
    {
        return @"<!DOCTYPE html>
<html lang=""pt-br"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <style>
        body {font - family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {max - width: 600px;
            margin: 20px auto;
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            overflow: hidden;
        }
        .header {background - color: #AB8262;
            color: #ffffff;
            text-align: center;
            padding: 20px;
        }
        .content {padding: 20px;
        }
        .content h1 {font - size: 24px;
            margin: 0 0 20px;
        }
        .content p {font - size: 16px;
            margin: 0 0 20px;
            line-height: 1.6;
        }
        .button {display: block;
            width: 200px;
            margin: 0 auto 20px;
            padding: 10px;
            background-color: #BB9C7D;
            color: #ffffff;
            text-align: center;
            border-radius: 5px;
            text-decoration: none;
        }
        .footer {background - color: #f4f4f4;
            text-align: center;
            padding: 10px;
            font-size: 12px;
            color: #888888;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>Confirmação de Pedido</h1>
        </div>
        <div class=""content"">
            <h1>Olá [Nome do Cliente],</h1>
            <p>Seu pedido #[Número do Pedido] foi criado com sucesso! Abaixo estão os detalhes do seu pedido:</p>
            <p><strong>Data do Pedido:</strong> [Data do Pedido]</p>
            <p><strong>Itens do Pedido:</strong></p>
            <ul>
                <li>Item 1 - Quantidade: [Quantidade] - Preço: [Preço]</li>
                <li>Item 2 - Quantidade: [Quantidade] - Preço: [Preço]</li>
                <!-- Adicione mais itens conforme necessário -->
            </ul>
            <p><strong>Total do Pedido:</strong> [Total do Pedido]</p>
            <p>Você pode acompanhar o status do seu pedido clicando no link abaixo:</p>
            <a href=""[Link de Rastreamento]"" class=""button"">Acompanhar Pedido</a>
            <p>Se você tiver alguma dúvida ou precisar de assistência, por favor entre em contato com nosso time de suporte.</p>
            <p>Obrigado,<br>Equipe Oh My Dog</p>
        </div>
        <div class=""footer"">
            <p>&copy; 2024 Oh My Dog. Todos os direitos reservados.</p>
        </div>
    </div>
</body>
</html>";
    }
    public static string ReadTemplateOrderStatusChanged()
    {
        return @"<!DOCTYPE html>
<html lang=""pt-br"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            overflow: hidden;
        }
        .header {
            background-color: #AB8262;
            color: #ffffff;
            text-align: center;
            padding: 20px;
        }
        .content {
            padding: 20px;
        }
        .content h1 {
            font-size: 24px;
            margin: 0 0 20px;
        }
        .content p {
            font-size: 16px;
            margin: 0 0 20px;
            line-height: 1.6;
        }
        .button {
            display: block;
            width: 200px;
            margin: 0 auto 20px;
            padding: 10px;
            background-color: #BB9C7D;
            color: #ffffff;
            text-align: center;
            border-radius: 5px;
            text-decoration: none;
        }
        .footer {
            background-color: #f4f4f4;
            text-align: center;
            padding: 10px;
            font-size: 12px;
            color: #888888;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>Atualização de Status do Pedido</h1>
        </div>
        <div class=""content"">
            <h1>Olá [Nome do Cliente],</h1>
            <p>O status do seu pedido #[Número do Pedido] foi atualizado. Veja os detalhes abaixo:</p>
            <p><strong>Status Atual:</strong> [Status do Pedido]</p>
            <p><strong>Data do Pedido:</strong> [Data do Pedido]</p>
            <p><strong>Itens do Pedido:</strong></p>
            <ul>
                <li>Item 1 - Quantidade: [Quantidade] - Preço: [Preço]</li>
                <li>Item 2 - Quantidade: [Quantidade] - Preço: [Preço]</li>
                <!-- Adicione mais itens conforme necessário -->
            </ul>
            <p><strong>Total do Pedido:</strong> [Total do Pedido]</p>
            <p>Você pode acompanhar o status do seu pedido clicando no link abaixo:</p>
            <a href=""[Link de Rastreamento]"" class=""button"">Acompanhar Pedido</a>
            <p>Se você tiver alguma dúvida ou precisar de assistência, por favor entre em contato com nosso time de suporte.</p>
            <p>Obrigado,<br>Equipe Oh My Dog</p>
        </div>
        <div class=""footer"">
            <p>&copy; 2024 Oh My Dog. Todos os direitos reservados.</p>
        </div>
    </div>
</body>
</html>";
    }
}