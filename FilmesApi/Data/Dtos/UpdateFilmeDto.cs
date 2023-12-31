﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O titulo do filme é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório!")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "O duração do filme é obrigatória!")]
        [Range(70, 600, ErrorMessage = "A duração deve ser de 70 a 600 minutos.")]
        public int Duracao { get; set; }
    }
}
