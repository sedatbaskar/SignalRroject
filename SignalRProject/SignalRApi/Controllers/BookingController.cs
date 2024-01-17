﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {

            var values = _bookingService.TGetListAll();
            return Ok(values);

        }

        [HttpPost]

        public IActionResult CreateBooking(CreateBookingDto createBookingDto)


        {

            Booking booking = new ()

            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,
                Description = createBookingDto.Description


            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon yapıldı");

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)

        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon silindi");

        }

        [HttpPut]

        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new ()
            {
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                BookingID = updateBookingDto.BookingID,
                Description = updateBookingDto.Description


            };

            _bookingService.TUpdate(booking);
            return Ok("Rezervazyon güncellendi");
        }

        [HttpGet("{id}")]

        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("BookingStatusApproved/{id}")]
        public IActionResult BookingStatusApproved(int id)
        {
            _bookingService.TBookingStatusApproved(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }

        [HttpGet("BookingStatusCancelled/{id}")]
        public IActionResult BookingStatusCancelled(int id)
        {
            _bookingService.TBookingStatusCancelled(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }

        
    }

}
