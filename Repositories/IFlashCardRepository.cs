﻿using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Repositories
{
    public interface IFlashCardRepository
    {
        Task<IEnumerable<FlashCardModel>> GetCards(FlashCardQueryParams flashCardQueryParams);

        Task AddCard(AddNewCardDTO addNewCardDTO);
    }
}
