const express = require('express');
const router = express.Router();
const pool = require('../databse');
const {isLoggedIn} = require('../lib/auth');

console.log(express.Router.post);
router.get('/add', isLoggedIn, (req, res)=>{
    res.render('links/add');
});

router.post('/add', isLoggedIn, async (req, res)=> {
    const {title, url, description} = req.body;
    const newLink = {
            title,
            url,
            description, 
            user_id : req.user.id
    };
    await pool.query('INSERT INTO links  set ?', [newLink])
    req.flash('success', 'Link saved successfully' );
    res.redirect('/links');
});
router.get('/', isLoggedIn, async (req, res)=>{
   const links =  await pool.query('SELECT * FROM links WHERE user_id = ?', [req.user.id]);
    console.log(links);
    res.render('links/list', { links });
});
router.get('/delete/:id', isLoggedIn, async(req, res)=> {
//console.log(req.params.id);
//res.send('Eliminado')
const {id} = req.params;
await pool.query('DELETE FROM links WHERE ID = ?', [id]);
req.flash('success', 'Link remove successfully')
res.redirect('/links')
});
router.get('/edit/:id', isLoggedIn, async(req,res)=>{
    const{id}= req.params;
    const links = await pool.query('SELECT * FROM links WHERE id = ?', [id])
  
    res.render('links/edit',{link : links[0]});
    
});
router.post('/edit/:id', isLoggedIn, async (req, res)=> {
    const{id} = req.params;
    const {title, description, url} = req.body;
    const newLink = {
        title,
        url,
        description
};
//console.log(newLink);
req.flash('success', 'Update Link successfully')
await pool.query('UPDATE links set ? WHERE id = ?', [newLink, id]);
res.redirect('/links');
});
module.exports = router;