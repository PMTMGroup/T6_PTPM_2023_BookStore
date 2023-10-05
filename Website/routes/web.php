<?php

use App\Http\Controllers\OpenAIController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/cart', function(){ return view('cart');})->name('cart.index');
Route::get('/', function(){ return view('home');})->name('home.index');
Route::get('/checkout', function(){ return view('checkout');})->name('checkout.index');
Route::get('/register', function(){ return view('register');})->name('register.index');
Route::post('/ai-question', [OpenAIController::class, 'OpenAIChatBot'])->name('sender');
