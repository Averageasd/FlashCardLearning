﻿using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Services
{
    public interface IFlashCardService
    {
        Task<IEnumerable<FlashCardModel>> GetCards(FlashCardQueryParams flashCardQueryParams);

        Task<FlashCardModel> AddCard(AddNewCardDTO addNewCardDTO);
        Task<FlashCardModel> GetSingleCard(AddNewCardDTO cardDTO);
    }
}
